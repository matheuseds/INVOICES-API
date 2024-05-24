using B1SLayer;
using INVOICES_API.Utils;
using Newtonsoft.Json;

namespace INTEGRACAO_MIC.Utils
{
    public class B2F_LOG
    {     
        public string Code { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public string ObjectType { get; set; }
        public string DocEntry { get; set; }
        [JsonProperty("U_B2F_TipoDoc")]
        public string B2F_TipoDoc { get; set; } 
        [JsonProperty("U_B2F_IdDoc")]
        public string B2F_IdDoc { get; set; }
        [JsonProperty("U_B2F_DtInteg")]
        public string B2F_DtInteg { get; set; }
        [JsonProperty("U_B2F_Status")]
        public string B2F_Status { get; set; }
        [JsonProperty("U_B2F_IdRet")]
        public string B2F_IdRet { get; set; }
        [JsonProperty("U_B2F_MsgRet")]
        public string B2F_MsgRet { get; set; }
        [JsonProperty("U_B2F_JsonEnv")]
        public object B2F_JsonEnv { get; set; }
        [JsonProperty("U_B2F_JsonRet")]
        public object B2F_JsonRet { get; set; }
        [JsonProperty("U_B2F_IdDocLeg")]
        public string B2F_IdDocLeg { get; set; }

        public async void InsertOrUpdateLog()
        {          
            HanaDAO dao = new HanaDAO();
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;

            var AppName = "API ESL Fatura CT-e";

            if (!string.IsNullOrEmpty(this.ObjectType))
            {
                this.B2F_TipoDoc = (string)dao.ExecuteScalar($@"select ""U_Table_Desc"" from ""{HanaDAO.Database}"".""@B2F_OBJETOS""  where ""U_ObjectType"" ='{this.ObjectType}'");
            }

            this.B2F_JsonEnv = this.B2F_JsonEnv != null ? JsonConvert.SerializeObject(this.B2F_JsonEnv, settings) : null;
            this.B2F_JsonRet = this.B2F_JsonRet != null ? JsonConvert.SerializeObject(this.B2F_JsonRet, settings) : null;

            //var total = dao.ExecuteScalar($@"SELECT COUNT(*) as ""Total"" from ""{HanaDAO.Database}"".""OUDO"" where ""TableName"" = 'B2F_LOG' ");
            try
            {
                var total = dao.ExecuteScalar($@"SELECT COUNT(*) as ""Total"" from ""{HanaDAO.Database}"".""OUDO"" where ""TableName"" = 'B2F_LOG' ");
                if (total.ToString() != "1")
                {

                    var exists = dao.ExecuteScalar(string.Format(File.ReadAllText(@"Queries\SelectB2F_LOG.sql"), HanaDAO.Database, AppName, B2F_TipoDoc, B2F_IdDoc));
                    if (exists != null)
                    {

                        dao.ExecuteNonQuery(string.Format(File.ReadAllText(@"Queries\UpdateB2F_LOG_OLD.sql"), HanaDAO.Database, AppName, B2F_TipoDoc, B2F_IdDoc, B2F_DtInteg, B2F_Status, B2F_IdRet, B2F_MsgRet, B2F_JsonEnv, B2F_JsonRet, B2F_IdDocLeg));
                    }
                    else
                    {
                        dao.ExecuteNonQuery(string.Format(File.ReadAllText(@"Queries\InsertB2F_LOG_OLD.sql"), HanaDAO.Database, AppName, B2F_TipoDoc, B2F_IdDoc, B2F_DtInteg, B2F_Status, B2F_IdRet, B2F_MsgRet, B2F_JsonEnv, B2F_JsonRet, B2F_IdDocLeg));
                    }
                }
                else
                {

                    var exists = dao.ExecuteScalar(string.Format(File.ReadAllText(@"Queries\SelectB2F_LOG.sql"), HanaDAO.Database, AppName, B2F_TipoDoc, B2F_IdDoc));
                    if (exists != null)
                    {

                        dao.ExecuteNonQuery(string.Format(File.ReadAllText(@"Queries\UpdateB2F_LOG.sql"), HanaDAO.Database, AppName, B2F_TipoDoc, B2F_IdDoc, B2F_DtInteg, B2F_Status, B2F_IdRet, B2F_MsgRet, B2F_JsonEnv, B2F_JsonRet, B2F_IdDocLeg));
                    }
                    else
                    {
                        dao.ExecuteNonQuery(string.Format(File.ReadAllText(@"Queries\InsertB2F_LOG.sql"), HanaDAO.Database, AppName, B2F_TipoDoc, B2F_IdDoc, B2F_DtInteg, B2F_Status, B2F_IdRet, B2F_MsgRet, B2F_JsonEnv, B2F_JsonRet, B2F_IdDocLeg));
                    }
                }
            }
            catch (Exception ex)
            {
               
            }


            //}
            //else
            //{
            //    #region LOG VIA SL
            //    try
            //    {

            //        var logexists = await SL.Connection.Request("B2F_LOG").Filter($"Name eq '{AppName}' and U_B2F_TipoDoc eq '{this.B2F_TipoDoc}' and U_B2F_IdDoc eq '{this.B2F_IdDoc}' ").GetAllAsync<B2F_LOG>();
            //        if (logexists.Count > 0)
            //        {

            //            await SL.Connection.Request($"B2F_LOG('{logexists.First().Code}')").WithJsonSerializerSettings(settings).PatchAsync(this);

            //        }
            //        else
            //        {
            //            this.Code = await GetLastCode();
            //            this.Name = AppName;
            //            await SL.Connection.Request("B2F_LOG").PostAsync(this);
            //        }
            //    }
            //    catch (System.Exception ex)
            //    {

            //        LogTxt.log.Info(ex.Message);
            //    }

            //    #endregion
            //}

        }

        public async Task<string> GetLastCode()
        {
            var replic = await SL.Connection.Request("B2F_LOG").Top(1).OrderBy("DocEntry desc").GetAsync<List<B2F_LOG>>();
            if (replic.Count > 0)
            {

                var nextCode = Convert.ToInt32(replic.FirstOrDefault().DocEntry) + 1;
                return nextCode.ToString();
            }
            else
            {
                return "1";
            }

        }
    }
}
