using Sap.Data.Hana;
using System.Data;
using System.Reflection;

namespace INVOICES_API.Utils
{
    public class HanaDAO : IDAO
    {
        private static HanaConnection Connection;

        private HanaDataAdapter DataAdapter = new HanaDataAdapter();

        private HanaDataReader DataReader;

        private HanaCommand Command;

        private static HanaTransaction Transaction;

        private static string ConnectionString;

        public static string Database
        {
            get;
            set;
        }

        public object Model
        {
            get;
            set;
        }

        static HanaDAO()
        {
            HanaDAO.Connection = new HanaConnection();
        }

        public HanaDAO()
        {
            if (string.IsNullOrEmpty(HanaDAO.ConnectionString))
            {
                HanaDAO.Connection = new HanaConnection();
                HanaDAO.Database = AppConfig.Configuration["Database"];
                string item = AppConfig.Configuration["Server"];
                string str = AppConfig.Configuration["DBUser"];
                string item1 = AppConfig.Configuration["DBPassword"];
                HanaDAO.ConnectionString = string.Concat(new string[] { "Server=", item, ";UserID=", str, ";Password=", item1 });
                Connection.ConnectionString = HanaDAO.ConnectionString;
                Connection.Open();
            }
        }

        public void BeginTransaction()
        {
            this.Connect();
            HanaDAO.Transaction = HanaDAO.Connection.BeginTransaction();
        }

        public void Close()
        {
            if (HanaDAO.Connection.State == ConnectionState.Open || HanaDAO.Connection.State == ConnectionState.Executing || HanaDAO.Connection.State == ConnectionState.Fetching)
            {
                HanaDAO.Connection.Close();
                HanaDAO.Connection.Dispose();
                HanaDAO.Connection = null;
                HanaDAO.ConnectionString = null;
            }
        }

        public void CommitTransaction()
        {
            if (HanaDAO.Transaction.Connection != null)
            {
                HanaDAO.Transaction.Commit();
            }
        }

        public void Connect()
        {

            // 
            // Current member / type: System.Void SendOPs.Utils.HanaDAO::Connect()
            // File path: C:\Users\marce\Desktop\Serviço Valida Validade Docs PN\SendOPs.dll
            // 
            // Product version: 2019.1.118.0
            // Exception in: System.Void Connect()
            // 
            // Referência de objeto não definida para uma instância de um objeto.
            //    em ..(TypeDefinition ,  , TypeSystem ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\EnumHelper.cs:linha 17
            //    em ..(BinaryExpression ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\RenameEnumValues.cs:linha 163
            //    em ..(ICodeNode ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 97
            //    em ..Visit(ICodeNode ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 276
            //    em ..(BinaryExpression ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 529
            //    em ..(BinaryExpression ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\RenameEnumValues.cs:linha 199
            //    em ..(ICodeNode ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 97
            //    em ..Visit(ICodeNode ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 276
            //    em ..(IfStatement ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 360
            //    em ..(ICodeNode ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 55
            //    em ..Visit(ICodeNode ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 276
            //    em ..Visit[,]( ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 286
            //    em ..Visit( ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 317
            //    em ..( ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Ast\BaseCodeTransformer.cs:linha 337
            //    em ..(DecompilationContext ,  ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Steps\RenameEnumValues.cs:linha 48
            //    em ..(MethodBody ,  , ILanguage ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:linha 88
            //    em ..(MethodBody , ILanguage ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:linha 70
            //    em Telerik.JustDecompiler.Decompiler.Extensions.( , ILanguage , MethodBody , DecompilationContext& ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:linha 95
            //    em Telerik.JustDecompiler.Decompiler.Extensions.(MethodBody , ILanguage , DecompilationContext& ,  ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:linha 58
            //    em ..(ILanguage , MethodDefinition ,  ) na C:\DeveloperTooling_JD_Agent1\_work\15\s\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:linha 117
            // 
            // mailto: JustDecompilePublicFeedback@telerik.com

        }

        public void ExecuteNonQuery(string Hana)
        {
            try
            {
                this.Connect();
                this.Command = new HanaCommand(Hana, HanaDAO.Connection)
                {
                    CommandTimeout = 120,
                    CommandType = CommandType.Text,
                    Transaction = HanaDAO.Transaction
                };
                this.Command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw new Exception(string.Concat("Erro ao executar ExecuteNonQuery: ", exception.Message));
            }
        }

        public HanaDataReader ExecuteReader(string Hana)
        {
            HanaDataReader dataReader;
            try
            {
                this.Connect();
                this.Command = new HanaCommand(Hana, HanaDAO.Connection)
                {
                    CommandTimeout = 120,
                    CommandType = CommandType.Text,
                    Transaction = HanaDAO.Transaction
                };
                this.DataReader = this.Command.ExecuteReader();
                dataReader = this.DataReader;
            }
            catch (Exception exception)
            {
                throw new Exception(string.Concat("Erro ao executar HanaDataReader: ", exception.Message));
            }
            return dataReader;
        }

        public object ExecuteScalar(string Hana)
        {
            object obj;
            try
            {
                this.Connect();
                this.Command = new HanaCommand(Hana, HanaDAO.Connection)
                {
                    CommandTimeout = 120,
                    CommandType = CommandType.Text,
                    Transaction = HanaDAO.Transaction
                };
                obj = this.Command.ExecuteScalar();
            }
            catch (Exception exception)
            {
                throw new Exception(string.Concat("Erro ao executar ExecuteScalar: ", exception.Message));
            }
            return obj;
        }

        public List<T> FillListFromCommand<T>(string Hana)
        {
            Console.WriteLine("Executando query...");

            List<T> list = new List<T>();

            using (HanaDataReader hanaDataReader = this.ExecuteReader(Hana))
            {
                while (hanaDataReader.Read())
                {
                    T t = Activator.CreateInstance<T>();
                    for (int i = 0; i < hanaDataReader.FieldCount; i++)
                    {
                        try
                        {
                            PropertyInfo property = t.GetType().GetProperty(hanaDataReader.GetName(i));

                            //Console.WriteLine($"Lendo propriedade: {property.Name}");

                            if (property == null)
                            {
                                throw new Exception(string.Concat("Propriedade ", hanaDataReader.GetName(i), " não encontrada no model"));
                            }
                            if (!hanaDataReader.IsDBNull(i))
                            {
                                if (hanaDataReader.GetFieldType(i) != typeof(decimal))
                                {
                                    Console.WriteLine($"Valor propriedade: {hanaDataReader.GetValue(i)}");

                                    property.SetValue(t, hanaDataReader.GetValue(i), null);
                                }
                                else
                                {
                                    Console.WriteLine($"Valor propriedade: {Convert.ToDouble(hanaDataReader.GetValue(i).ToString())}");

                                    property.SetValue(t, Convert.ToDouble(hanaDataReader.GetValue(i).ToString()), null);
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                            throw new Exception(ex.ToString());
                        }
                    }
                    list.Add(t);
                }
            }
            return list;
        }

        public string GetConnectedServer()
        {
            return HanaDAO.Connection.DataSource;
        }

        public void RollbackTransaction()
        {
            if (HanaDAO.Transaction.Connection != null)
            {
                HanaDAO.Transaction.Rollback();
            }
        }
    }
}