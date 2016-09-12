
using System.Collections;
using System.Collections.Generic;
using InterestAndFeeAnalyzer.IO;

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

        public ImportExporterStrategy StorageStrategy { get; set; }

        public void Add(BankAccount account)
        {
            if (account!=null)
                _accounts.Add(account);
        }

        public void Load(string filename)
        {
            if (!string.IsNullOrWhiteSpace(filename) && StorageStrategy != null)
                _accounts = StorageStrategy.Load(filename);
        }

        public void Save(string filename)
        {
            if (!string.IsNullOrWhiteSpace(filename) && StorageStrategy != null)
                StorageStrategy.Save(filename, _accounts);
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
