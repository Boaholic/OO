using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace InterestAndFeeAnalyzer
{
    /// <summary>
    /// Bank Account Set
    /// 
    /// Among other things, this class includes an example of how to deserialize a whole list of bank account objects from a file
    /// </summary>
    public class BankAccountSet : IEnumerable<BankAccount>
    {
        private List<BankAccount> _accounts = new List<BankAccount>();
        protected StreamWriter Writer { get; set; }
        protected StreamReader Reader { get; set; }

        public void Add(BankAccount account)
        {
            if (account!=null)
                _accounts.Add(account);
        }

        public void LoadFromXml(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<BankAccount>), new Type[] { typeof(BankAccount), typeof(CheckingAccount), typeof(SavingsAccount) });

            if (OpenReader(filename))
            {
                _accounts = serializer.Deserialize(Reader) as List<BankAccount>;
                Reader.Close();
            }
        }

        public void SaveToXml(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<BankAccount>), new Type[] { typeof(BankAccount), typeof(CheckingAccount), typeof(SavingsAccount) });

            if (OpenWriter(filename))
            {
                serializer.Serialize(Writer, _accounts);
                Writer.Close();
            }
        }

        protected virtual bool OpenWriter(string filename)
        {
            bool result = false;
            try
            {
                Writer = new StreamWriter(filename);
                result = true;
            }
            catch (Exception err)
            {
                Console.WriteLine($"Cannot open output file {filename}, error={err}");
            }

            return result;
        }

        protected virtual bool OpenReader(string filename)
        {
            bool result = false;
            try
            {
                Reader = new StreamReader(filename);
                result = true;
            }
            catch (Exception err)
            {
                Console.WriteLine($"Cannot open input file {filename}, error={err}");
            }

            return result;
        }

        public IEnumerator<BankAccount> GetEnumerator()
        {
            return _accounts.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BankAccountEnum(_accounts.ToArray());
        }
    }

    public class BankAccountEnum : IEnumerator
    {
        private readonly BankAccount[] _accounts;
        private int _currentPosition = -1;

        public BankAccountEnum(BankAccount[] accounts)
        {
            _accounts = accounts;
        }

        public bool MoveNext()
        {
            return (++_currentPosition < _accounts.Length);
        }

        public void Reset()
        {
            _currentPosition = -1;
        }

        object IEnumerator.Current { get { return Current; } }

        public BankAccount Current
        {
            get
            {
                return (_currentPosition >= 0 && _currentPosition < _accounts.Length) ? _accounts[_currentPosition] : null;
            }
        }
    }

}
