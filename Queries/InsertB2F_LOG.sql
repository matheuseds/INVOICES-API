﻿
INSERT INTO "{0}"."@B2F_LOG"("Code","Name","DocEntry","CreateDate","UpdateDate","UpdateTime","CreateTime","U_B2F_TipoDoc","U_B2F_IdDoc"  ,"U_B2F_DtInteg","U_B2F_Status","U_B2F_IdRet","U_B2F_MsgRet","U_B2F_JsonEnv","U_B2F_JsonRet","U_B2F_IdDocLeg"
) VALUES ("{0}"."U_B2F_LOG_S".NEXTVAL,'{1}',"{0}"."U_B2F_LOG_S".NEXTVAL,current_date,current_date,TO_INT(LPAD(REPLACE(TO_VARCHAR(current_Time),':',''),4)),TO_INT(LPAD(REPLACE(TO_VARCHAR(current_Time),':',''),4)),'{2}','{3}',current_Date,'{5}','{6}','{7}','{8}','{9}','{10}')

