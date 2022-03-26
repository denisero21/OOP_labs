using System;
using System.Data;
using GenericParsing;
using System.Collections.Generic;

namespace lab1
{
    public class Database
    {
        TableSet tableSet = new TableSet();
        Bank[] Banks = new Bank[3];

        public List<Account> Accounts = new List<Account>();
        public List<Credit> Credits = new List<Credit>();
        public List<Installment> Installments = new List<Installment>();
        public List<Client> Clients = new List<Client>();
        public List<SalaryProject> SalaryProjects = new List<SalaryProject>();
        public List<Company> Companies = new List<Company>();

        public Database() 
        {
            GetData();
        }

        public void GetData()
        {
            tableSet.CreateClientTable();
            tableSet.CreateAccountTable();
            tableSet.CreateBankTable();
            tableSet.CreateCreditTable();
            tableSet.CreateInstallmentTable();
            tableSet.CreateSalaryProjectTable();
            tableSet.CreateCompanyTable();
            using (GenericParser parser = new GenericParser())
            {
                parser.SetDataSource("Clients.txt");

                parser.ColumnDelimiter = ',';
                parser.FirstRowHasHeader = true;
                parser.TextQualifier = '\"';

                while (parser.Read())
                {
                    tableSet.Data.Tables["Clients"].Rows.Add(new object[] { parser["UserID"], parser["Login"],
                        parser["Password"], parser["Name"], parser["SecondName"],
                        parser["Patronymic"], parser["PhoneNumber"], parser["Email"],
                        parser["Passport"], parser["IdNumb"], parser["Country"], parser["Company"] });

                    Clients.Add(GetClient(parser["Login"]));
                }
                parser.SetDataSource("Accounts.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Accounts"].Rows.Add(new object[] { parser["Id"], parser["AccountNumber"], 
                        parser["UserID"], parser["BankName"], parser["Sum"], parser["Active"] });
                    Accounts.Add(GetAccount(parser["AccountNumber"]));
                }
                parser.SetDataSource("Credits.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Credits"].Rows.Add(new object[] { parser["Id"], parser["CreditNumber"],
                        parser["UserID"], parser["Months"], parser["Sum"], parser["Percents"],parser["Bank"], parser["Approved"], parser["Cancelled"] });
                    Credits.Add(GetCredit(parser["CreditNumber"]));
                }
                parser.SetDataSource("Installments.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["Installments"].Rows.Add(new object[] { parser["Id"], parser["InstallmentNumber"],
                        parser["UserID"], parser["Months"], parser["Sum"], parser["Percents"],parser["Bank"], parser["Approved"], parser["Cancelled"] });
                    Installments.Add(GetInstallment(parser["InstallmentNumber"]));
                }
                parser.SetDataSource("Banks.txt");
                int i = 0;
                while(parser.Read())
                {
                    tableSet.Data.Tables["Installments"].Rows.Add(new object[] { parser["Name"] });
                    Banks[i] = new Bank(parser["Name"]);
                    i++;
                }
                parser.SetDataSource("SalaryProjects.txt");
                while (parser.Read())
                {
                    tableSet.Data.Tables["SalaryProjects"].Rows.Add(new object[] { parser["Id"], parser["SalaryProjectNumber"],
                        parser["UserID"], parser["Double"] });
                    SalaryProjects.Add(GetSalaryProject(parser["SalaryProjectNumber"]));
                }
                parser.SetDataSource("Companies.txt");
                {
                    tableSet.Data.Tables["Companies"].Rows.Add(new object[] { parser["CompanyId"], parser["Type"],
                        parser["Name"], parser["PAN"], parser["BIC"], parser["Adress"] });
                    Companies.Add(GetCompany(parser["Name"]));
                }
            }

        }

        public void AddClient(string userId, string login, string password, string firstName, string secondName, string patronymic, string phoneNumber, string email, string passport, string idNumb, string country, string company)
        {
            tableSet.Data.Tables["Clients"].Rows.Add(new object[] 
            {
                userId,
                login, 
                password, 
                firstName, 
                secondName, 
                patronymic, 
                phoneNumber, 
                email, 
                passport, 
                idNumb, 
                country, 
                company});
        }

        public void AddAccount(string id, string accnum,string userId, string bankname, double sum, bool active)
        {
            tableSet.Data.Tables["Accounts"].Rows.Add(new object[] 
            {   
                id,
                accnum,
                userId,
                bankname,
                sum,
                active
            });
        }

        public void AddBank (string name)
        {
            tableSet.Data.Tables["Banks"].Rows.Add(new object[]
                {
                name
            });
        }

        public void AddCompany(string type, string name, string PAN, string BIN, string Adress)
        {
            tableSet.Data.Tables["Companies"].Rows.Add(new object[]
                {
                 type, 
                 name, 
                 PAN, 
                 BIN,
                 Adress
            });
        }

        public void AddCredit(string id,string creditNumber,string userId, int month, double sum, double percent,string bankname, bool approved, bool cancelled)  
        {
            tableSet.Data.Tables["Credits"].Rows.Add(new object[]
                {
                id,
                creditNumber,
                userId,
                month,
                sum,
                percent,
                bankname,
                approved,
                cancelled
            });
        }

        public void AddInstallmet(string id,string installmentNumber, string userId, int month, double sum, double percent,string bankname, bool approved, bool cancelled)
        {
            tableSet.Data.Tables["Installmets"].Rows.Add(new object[]
                {
                id,
                installmentNumber,
                userId,
                month,
                sum,
                percent,
                bankname,
                approved,
                cancelled
            });
        }

        public void AddSalaryProect(string id, string salprjNumber, string userId, double sum, bool approved, bool cancelled)
        {
            tableSet.Data.Tables["SalaryProects"].Rows.Add(new object[]
                {
                id,
                salprjNumber,
                userId,
                sum,
                approved,
                cancelled
            });
        }


        public Client FindByLoginAndPassword(string login, string password)
        {
            Client FClient = null;
            DataRow[] row = tableSet.Data.Tables["Clients"].Select(" login = '" + login + "' AND Password = '" + password + "'");

            if (row.Length != 0)
            {
                FClient.GetClient(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"]),
                   Convert.ToString(row[0]["Name"]),
                   Convert.ToString(row[0]["Surname"]),
                   Convert.ToString(row[0]["Patronymic"]),
                   Convert.ToString(row[0]["PhoneNumber"]),
                   Convert.ToString(row[0]["Email"]),
                   Convert.ToString(row[0]["Passport"]),
                   Convert.ToString(row[0]["IdNumb"]),
                   Convert.ToString(row[0]["Country"]),
                   Convert.ToString(row[0]["Company"])
                );
            }
            return FClient;
        }

        public Client GetClient(string login)
        {
            Client FClient = null;
            DataRow[] row = tableSet.Data.Tables["Clients"].Select($" login = '{login}'");

            if (row.Length != 0)
            {
                FClient.GetClient(
                   Convert.ToString(row[0]["UserID"]),
                   Convert.ToString(row[0]["Login"]),
                   Convert.ToString(row[0]["Password"]),
                   Convert.ToString(row[0]["Name"]),
                   Convert.ToString(row[0]["Surname"]),
                   Convert.ToString(row[0]["Patronymic"]),
                   Convert.ToString(row[0]["PhoneNumber"]),
                   Convert.ToString(row[0]["Email"]),
                   Convert.ToString(row[0]["Passport"]),
                   Convert.ToString(row[0]["IdNumb"]),
                   Convert.ToString(row[0]["Country"]),
                   Convert.ToString(row[0]["Company"])
                );
            }
            return FClient;
        }

        public Company GetCompany(string companyName)
        {
            Company New = null;
            DataRow[] row = tableSet.Data.Tables["Companies"].Select($"Name = '{companyName}'");
            if (row.Length != 0)
            {
                New.GetCompany(
                    Convert.ToString(row[0]["CompanyId"]),
                    Convert.ToString(row[0]["Type"]),
                    Convert.ToString(row[0]["Name"]),
                    Convert.ToString(row[0]["PAN"]),
                    Convert.ToString(row[0]["BIC"]),
                    Convert.ToString(row[0]["Adress"])
                    );
            }
            return New;
        }

        public Account GetAccount(string accountNumber)
        {
            Account New = null;
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"AccountNumber = '{accountNumber}'");
            if (row.Length != 0)
            {
                New.GetAccount(
                    Convert.ToString(row[0]["Id"]),
                    Convert.ToString(row[0]["AccountNumber"]),
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToDouble(row[0]["Sum"]),
                    Convert.ToString(row[0]["BankName"])
                    );
            }
            return New;
        }

        public Credit GetCredit(string creditNumber)
        {
            Credit New = null;
            DataRow[] row = tableSet.Data.Tables["Credits"].Select($"CreditNumber = '{creditNumber}'");
            if (row.Length != 0)
            {
                New.GetCredit(
                    Convert.ToString(row[0]["Id"]),
                    Convert.ToString(row[0]["CreditNumber"]),
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToString(row[0]["Bank"]),
                    Convert.ToInt16(row[0]["Month"]),
                    Convert.ToDouble(row[0]["Sum"])
                    );
            }
            return New;
        }

        public Installment GetInstallment(string installmentNumber)
        {
            Installment New = null;
            DataRow[] row = tableSet.Data.Tables["Installments"].Select($"InstallmentNumber = '{installmentNumber}'");
            if (row.Length != 0)
            {
                New.GetInstallment(
                    Convert.ToString(row[0]["Id"]),
                    Convert.ToString(row[0]["CreditNumber"]),
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToString(row[0]["Bank"]),
                    Convert.ToInt16(row[0]["Month"]),
                    Convert.ToDouble(row[0]["Sum"])
                    );
            }
            return New;
        }

        public SalaryProject GetSalaryProject(string salprjNumber)
        {
            SalaryProject New = null;
            DataRow[] row = tableSet.Data.Tables["SalaryProjects"].Select($"SalaryProjectNumber = '{salprjNumber}'");
            if (row.Length != 0)
            {
                New.GetSalaryProject(
                    Convert.ToString(row[0]["Id"]),
                    Convert.ToString(row[0]["SalaryProjectNumber"]),
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToDouble(row[0]["Sum"])
                    );
            }
            return New;
        }

        public AnotherSpecialist GetAnotherSpecialist(string login)
        {
            AnotherSpecialist New = null;
            DataRow[] row = tableSet.Data.Tables["AnotherSpecialists"].Select($"Login = '{login}'");
            if (row.Length != 0)
            {
                New.GetAnotherSpecialist(
                    Convert.ToString(row[0]["UserID"]),
                    Convert.ToString(row[0]["Login"]),
                    Convert.ToString(row[0]["Password"])
                    );
            }
            return New;
        }

        public void RemoveAccount(string accountNumber)
        {
            DataRow[] row = tableSet.Data.Tables["Accounts"].Select($"Name = '{accountNumber}'");
            row[0].Delete();
            tableSet.Data.Tables["Accounts"].AcceptChanges();
        }

        public void RemoveCredit(string creditNumber)
        {
            DataRow[] row = tableSet.Data.Tables["Credits"].Select($"CreditNumber = '{creditNumber}'");
            row[0].Delete();
            tableSet.Data.Tables["Credits"].AcceptChanges();
        }

        public void RemoveInstallment(string installmentNumber)
        {
            DataRow[] row = tableSet.Data.Tables["Installments"].Select($"InstallmentNumber = '{installmentNumber}'");
            row[0].Delete();
            tableSet.Data.Tables["Installments"].AcceptChanges();
        }

        public void RemoveSalaryProject(string salprjNimber)
        {
            DataRow[] row = tableSet.Data.Tables["SalaryProjects"].Select($"SalaryProjectNumber = '{salprjNimber}'");
            row[0].Delete();
            tableSet.Data.Tables["SalaryProjects"].AcceptChanges();
        }

        public void SetBanks(System.Windows.Forms.ComboBox comboBox)
        {
            DataRow[] row = tableSet.Data.Tables["Banks"].Select();
            for (int i = 0; i < row.Length; i++)
            {
                comboBox.Items.Add(row[i]["Name"]);
            }
        }

        public Bank GetBank(string name)
        {
            Bank bank = null;

            for (int i = 0; i < Banks.Length; i++)
            {
                if (name == Convert.ToString(Banks[i].Name))
                {
                    bank = Banks[i];
                }
            }
            return bank;
        }
    }
}
