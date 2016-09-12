using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace InterestAndFeeAnalyzer.IO
{
    public class XmlImportExportStrategy : ImportExporterStrategy
    {

        public override List<BankAccount> Load(string filename)
        {
            List<BankAccount> accounts = null;
            XmlSerializer serializer = new XmlSerializer(typeof(List<BankAccount>), new Type[] { typeof(BankAccount), typeof(CheckingAccount), typeof(SavingsAccount) });

            if (OpenReader(filename))
            {
                accounts = serializer.Deserialize(Reader) as List<BankAccount>;
                Reader.Close();
            }

            return accounts;
        }

        public override void Save(string filename, List<BankAccount> accounts)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<BankAccount>), new Type[] { typeof(BankAccount), typeof(CheckingAccount), typeof(SavingsAccount) });

            if (OpenWriter(filename))
            {
                serializer.Serialize(Writer, accounts);
                Writer.Close();
            }
        }


    }
}
