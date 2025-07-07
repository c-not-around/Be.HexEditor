using System;
using System.Collections.Generic;
using System.Text;

namespace Be.Windows.Forms
{
    /// <summary>
    /// The interface for objects that can translate between characters and bytes.
    /// </summary>
    public interface IByteCharConverter
    {
        /// <summary>
        /// Returns the character to display for the byte passed across.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        char ToChar(byte b);

        /// <summary>
        /// Returns the byte to use when the character passed across is entered during editing.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        byte ToByte(char c);
    }

    /// <summary>
    /// A byte char provider that can translate bytes encoded in ANSI
    /// </summary>
    public class AnsiByteCharConvertor : IByteCharConverter
    {
        /// <summary>
        /// Returns the ANSI character corresponding to the byte passed across.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual char ToChar(byte b)
        {
            return (b < 0x21) || (0x7E < b && b < 0xA1) || (b == 0xAD) ? '.' : (char)b;
        }

        /// <summary>
        /// Returns the byte corresponding to the ANSI character passed across.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public virtual byte ToByte(char c)
        {
            return (byte)c;
        }

        /// <summary>
        /// Returns a description of the byte char provider.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ANSI";
        }
    }

    /// <summary>
    /// A byte char provider that can translate bytes encoded in ASCII
    /// </summary>
    public class AsciiByteCharConvertor : IByteCharConverter
    {
        private Encoding _Encoding = Encoding.ASCII;

        /// <summary>
        /// Returns the ASCII character corresponding to the byte passed across.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual char ToChar(byte b)
        {
            string encoded = _Encoding.GetString(new byte[] { b });
            return (b < 0x21)|| (b == 0x7F) || (encoded.Length < 1) ? '.' : encoded[0];
        }

        /// <summary>
        /// Returns the byte corresponding to the ASCII character passed across.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public virtual byte ToByte(char c)
        {
            byte[] decoded = _Encoding.GetBytes(new char[] { c });
            return decoded.Length > 0 ? decoded[0] : (byte)0;
        }

        /// <summary>
        /// Returns a description of the byte char provider.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ASCII";
        }
    }

    /// <summary>
    /// A byte char provider that can translate bytes encoded in UTF-8
    /// </summary>
    public class Utf8ByteCharConvertor : IByteCharConverter
    {
        private Encoding _Encoding = Encoding.UTF8;

        /// <summary>
        /// Returns the UTF-8 character corresponding to the byte passed across.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual char ToChar(byte b)
        {
            string encoded = _Encoding.GetString(new byte[] { b });
            return (b < 0x21) || (b == 0x7F) || (encoded.Length < 1) ? '.' : encoded[0];
        }

        /// <summary>
        /// Returns the byte corresponding to the UTF-8 character passed across.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public virtual byte ToByte(char c)
        {
            byte[] decoded = _Encoding.GetBytes(new char[] { c });
            return decoded.Length > 0 ? decoded[0] : (byte)0;
        }

        /// <summary>
        /// Returns a description of the byte char provider.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "UTF-8";
        }
    }

    /// <summary>
    /// A byte char provider that can translate bytes encoded in CP-1251
    /// </summary>
    public class Cp1251ByteCharConvertor : IByteCharConverter
    {
        private Encoding _Encoding = Encoding.GetEncoding(1251);

        /// <summary>
        /// Returns the CP-1251 character corresponding to the byte passed across.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public virtual char ToChar(byte b)
        {
            string encoded = _Encoding.GetString(new byte[] { b });
            return (b < 0x21) || (b == 0x7F) || (b == 0xA0) || (b == 0xAD) || (encoded.Length < 1) ? '.' : encoded[0];
        }

        /// <summary>
        /// Returns the byte corresponding to the CP-1251 character passed across.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public virtual byte ToByte(char c)
        {
            byte[] decoded = _Encoding.GetBytes(new char[] { c });
            return decoded.Length > 0 ? decoded[0] : (byte)0;
        }

        /// <summary>
        /// Returns a description of the byte char provider.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "CP-1251";
        }
    }
}