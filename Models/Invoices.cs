using B1SLayer;
using INTEGRACAO_MIC.Utils;
using INVOICES_API.Utils;
using Newtonsoft.Json;

namespace INVOICES_API.Models
{
    public class Invoices
    {
        public int? DocEntry { get; set; }
        public int? DocNum { get; set; }
        public string? DocType { get; set; }
        public string? HandWritten { get; set; }
        public string? Printed { get; set; }
        public string? DocDate { get; set; }
        public string? DocDueDate { get; set; }
        public string? CardCode { get; set; }
        public string? CardName { get; set; }
        public string? Address { get; set; }
        public string? NumAtCard { get; set; }
        public float? DocTotal { get; set; }
        public object? AttachmentEntry { get; set; }
        public string? DocCurrency { get; set; }
        public float? DocRate { get; set; }
        public string? Reference1 { get; set; }
        public object? Reference2 { get; set; }
        public string? Comments { get; set; }
        public string? JournalMemo { get; set; }
        public int? PaymentGroupCode { get; set; }
        public string? DocTime { get; set; }
        public int? SalesPersonCode { get; set; }
        public int? TransportationCode { get; set; }
        public string? Confirmed { get; set; }
        public int? ImportFileNum { get; set; }
        public string? SummeryType { get; set; }
        public int? ContactPersonCode { get; set; }
        public string? ShowSCN { get; set; }
        public int? Series { get; set; }
        public string? TaxDate { get; set; }
        public string? PartialSupply { get; set; }
        public string? DocObjectCode { get; set; }
        public string? ShipToCode { get; set; }
        public object? Indicator { get; set; }
        public object? FederalTaxID { get; set; }
        public float? DiscountPercent { get; set; }
        public string? PaymentReference { get; set; }
        public string? CreationDate { get; set; }
        public string? UpdateDate { get; set; }
        public int? FinancialPeriod { get; set; }
        public int? UserSign { get; set; }
        public int? TransNum { get; set; }
        public float? VatSum { get; set; }
        public float? VatSumSys { get; set; }
        public float? VatSumFc { get; set; }
        public string? NetProcedure { get; set; }
        public float? DocTotalFc { get; set; }
        public float? DocTotalSys { get; set; }
        public object? Form1099 { get; set; }
        public object? Box1099 { get; set; }
        public string? RevisionPo { get; set; }
        public object? RequriedDate { get; set; }
        public object? CancelDate { get; set; }
        public string? BlockDunning { get; set; }
        public string? Submitted { get; set; }
        public int? Segment { get; set; }
        public string? PickStatus { get; set; }
        public string? Pick { get; set; }
        public string? PaymentMethod { get; set; }
        public string? PaymentBlock { get; set; }
        public object? PaymentBlockEntry { get; set; }
        public object? CentralBankIndicator { get; set; }
        public string? MaximumCashDiscount { get; set; }
        public string? Reserve { get; set; }
        public object? Project { get; set; }
        public object? ExemptionValidityDateFrom { get; set; }
        public object? ExemptionValidityDateTo { get; set; }
        public string? WareHouseUpdateType { get; set; }
        public string? Rounding { get; set; }
        public object? ExternalCorrectedDocNum { get; set; }
        public object? InternalCorrectedDocNum { get; set; }
        public object? NextCorrectingDocument { get; set; }
        public string? DeferredTax { get; set; }
        public string? TaxExemptionLetterNum { get; set; }
        public float? WTApplied { get; set; }
        public float? WTAppliedFC { get; set; }
        public string? BillOfExchangeReserved { get; set; }
        public object? AgentCode { get; set; }
        public float? WTAppliedSC { get; set; }
        public float? TotalEqualizationTax { get; set; }
        public float? TotalEqualizationTaxFC { get; set; }
        public float? TotalEqualizationTaxSC { get; set; }
        public int? NumberOfInstallments { get; set; }
        public string? ApplyTaxOnFirstInstallment { get; set; }
        public float? WTNonSubjectAmount { get; set; }
        public float? WTNonSubjectAmountSC { get; set; }
        public float? WTNonSubjectAmountFC { get; set; }
        public float? WTExemptedAmount { get; set; }
        public float? WTExemptedAmountSC { get; set; }
        public float? WTExemptedAmountFC { get; set; }
        public float? BaseAmount { get; set; }
        public float? BaseAmountSC { get; set; }
        public float? BaseAmountFC { get; set; }
        public float? WTAmount { get; set; }
        public float? WTAmountSC { get; set; }
        public float? WTAmountFC { get; set; }
        public object? VatDate { get; set; }
        public object? DocumentsOwner { get; set; }
        public object? FolioPrefixString { get; set; }
        public object? FolioNumber { get; set; }
        public string? DocumentSubType { get; set; }
        public object? BPChannelCode { get; set; }
        public int? BPChannelContact { get; set; }
        public string? Address2 { get; set; }
        public string? DocumentStatus { get; set; }
        public string? PeriodIndicator { get; set; }
        public string? PayToCode { get; set; }
        public object? ManualNumber { get; set; }
        public string? UseShpdGoodsAct { get; set; }
        public string? IsPayToBank { get; set; }
        public object? PayToBankCountry { get; set; }
        public object? PayToBankCode { get; set; }
        public object? PayToBankAccountNo { get; set; }
        public object? PayToBankBranch { get; set; }
        public int? BPL_IDAssignedToInvoice { get; set; }
        public float? DownPayment { get; set; }
        public string? ReserveInvoice { get; set; }
        public int? LanguageCode { get; set; }
        public object? TrackingNumber { get; set; }
        public object? PickRemark { get; set; }
        public object? ClosingDate { get; set; }
        public int? SequenceCode { get; set; }
        public int? SequenceSerial { get; set; }
        public string? SeriesString { get; set; }
        public string? SubSeriesString { get; set; }
        public string? SequenceModel { get; set; }
        public string? UseCorrectionVATGroup { get; set; }
        public float? TotalDiscount { get; set; }
        public float? DownPaymentAmount { get; set; }
        public float? DownPaymentPercentage { get; set; }
        public string? DownPaymentType { get; set; }
        public float? DownPaymentAmountSC { get; set; }
        public float? DownPaymentAmountFC { get; set; }
        public float? VatPercent { get; set; }
        public float? ServiceGrossProfitPercent { get; set; }
        public object? OpeningRemarks { get; set; }
        public string? ClosingRemarks { get; set; }
        public float? RoundingDiffAmount { get; set; }
        public float? RoundingDiffAmountFC { get; set; }
        public float? RoundingDiffAmountSC { get; set; }
        public string? Cancelled { get; set; }
        public object? SignatureInputMessage { get; set; }
        public object? SignatureDigest { get; set; }
        public object? CertificationNumber { get; set; }
        public object? PrivateKeyVersion { get; set; }
        public string? ControlAccount { get; set; }
        public string? InsuranceOperation347 { get; set; }
        public string? ArchiveNonremovableSalesQuotation { get; set; }
        public object? GTSChecker { get; set; }
        public object? GTSPayee { get; set; }
        public int? ExtraMonth { get; set; }
        public int? ExtraDays { get; set; }
        public int? CashDiscountDateOffset { get; set; }
        public string? StartFrom { get; set; }
        public string? NTSApproved { get; set; }
        public object? ETaxWebSite { get; set; }
        public object? ETaxNumber { get; set; }
        public object? NTSApprovedNumber { get; set; }
        public string? EDocGenerationType { get; set; }
        public object? EDocSeries { get; set; }
        public object? EDocNum { get; set; }
        public object? EDocExportFormat { get; set; }
        public string? EDocStatus { get; set; }
        public object? EDocErrorCode { get; set; }
        public object? EDocErrorMessage { get; set; }
        public string? DownPaymentStatus { get; set; }
        public object? GroupSeries { get; set; }
        public object? GroupNumber { get; set; }
        public string? GroupHandWritten { get; set; }
        public object? ReopenOriginalDocument { get; set; }
        public object? ReopenManuallyClosedOrCanceledDocument { get; set; }
        public string? CreateOnlineQuotation { get; set; }
        public object? POSEquipmentNumber { get; set; }
        public object? POSManufacturerSerialNumber { get; set; }
        public object? POSCashierNumber { get; set; }
        public string? ApplyCurrentVATRatesForDownPaymentsToDraw { get; set; }
        public string? ClosingOption { get; set; }
        public object? SpecifiedClosingDate { get; set; }
        public string? OpenForLandedCosts { get; set; }
        public string? AuthorizationStatus { get; set; }
        public float? TotalDiscountFC { get; set; }
        public float? TotalDiscountSC { get; set; }
        public string? RelevantToGTS { get; set; }
        public string? BPLName { get; set; }
        public string? VATRegNum { get; set; }
        public object? AnnualInvoiceDeclarationReference { get; set; }
        public object? Supplier { get; set; }
        public object? Releaser { get; set; }
        public object? Receiver { get; set; }
        public object? BlanketAgreementNumber { get; set; }
        public string? IsAlteration { get; set; }
        public string? CancelStatus { get; set; }
        public string? AssetValueDate { get; set; }
        public string? InvoicePayment { get; set; }
        public string? DocumentDelivery { get; set; }
        public object? AuthorizationCode { get; set; }
        public object? StartDeliveryDate { get; set; }
        public object? StartDeliveryTime { get; set; }
        public object? EndDeliveryDate { get; set; }
        public object? EndDeliveryTime { get; set; }
        public object? VehiclePlate { get; set; }
        public object? ATDocumentType { get; set; }
        public object? ElecCommStatus { get; set; }
        public object? ElecCommMessage { get; set; }
        public string? ReuseDocumentNum { get; set; }
        public string? ReuseNotaFiscalNum { get; set; }
        public string? PrintSEPADirect { get; set; }
        public object? FiscalDocNum { get; set; }
        public object? POSDailySummaryNo { get; set; }
        public object? POSReceiptNo { get; set; }
        public object? PointOfIssueCode { get; set; }
        public object? Letter { get; set; }
        public object? FolioNumberFrom { get; set; }
        public object? FolioNumberTo { get; set; }
        public string? InterimType { get; set; }
        public int? RelatedType { get; set; }
        public object? RelatedEntry { get; set; }
        public object? SAPPassport { get; set; }
        public object? DocumentTaxID { get; set; }
        public object? DateOfReportingControlStatementVAT { get; set; }
        public object? ReportingSectionControlStatementVAT { get; set; }
        public string? ExcludeFromTaxReportControlStatementVAT { get; set; }
        public object? POS_CashRegister { get; set; }
        public string? UpdateTime { get; set; }
        public object? CreateQRCodeFrom { get; set; }
        public object? PriceMode { get; set; }
        public string? Revision { get; set; }
        public object? OriginalRefNo { get; set; }
        public object? OriginalRefDate { get; set; }
        public object? GSTTransactionType { get; set; }
        public object? OriginalCreditOrDebitNo { get; set; }
        public object? OriginalCreditOrDebitDate { get; set; }
        public object? ECommerceOperator { get; set; }
        public object? ECommerceGSTIN { get; set; }
        public string? ShipFrom { get; set; }
        public string? CommissionTrade { get; set; }
        public string? CommissionTradeReturn { get; set; }
        public string? UseBillToAddrToDetermineTax { get; set; }
        public int? IssuingReason { get; set; }
        public object? Cig { get; set; }
        public object? Cup { get; set; }
        public string? EDocType { get; set; }
        public string? FCEAsPaymentMeans { get; set; }
        public float? PaidToDate { get; set; }
        public float? PaidToDateFC { get; set; }
        public float? PaidToDateSys { get; set; }
        public int? BaseType { get; set; }
        public object? BaseEntry { get; set; }
        public object? FatherCard { get; set; }
        public string? FatherType { get; set; }
        public string? ShipState { get; set; }
        public object? ShipPlace { get; set; }
        public object? CustOffice { get; set; }
        public object? FCI { get; set; }
        public object? AddLegIn { get; set; }
        public object? LegTextF { get; set; }
        public string? DANFELgTxt { get; set; }
        public string? IndFinal { get; set; }
        public int? DataVersion { get; set; }
        public object? LastPageFolioNumber { get; set; }
        public object[]? Document_ApprovalRequests { get; set; }
        public List<DocumentLine>? DocumentLines { get; set; }
        public object[]? ElectronicProtocols { get; set; }
        public object[]? DocumentAdditionalExpenses { get; set; }
        public object[]? WithholdingTaxDataWTXCollection { get; set; }
        public object[]? WithholdingTaxDataCollection { get; set; }
        public object[]? DocumentPackages { get; set; }
        public object[]? DocumentSpecialLines { get; set; }
        public List<Documentinstallment>? DocumentInstallments { get; set; }
        public object[]? DownPaymentsToDraw { get; set; }
        public Taxextension? TaxExtension { get; set; }
        public Addressextension? AddressExtension { get; set; }
        public List<Documentreference>? DocumentReferences { get; set; }

        public static async Task<Invoices> Create(Invoices invoices)
        {
            B2F_LOG log = new B2F_LOG();

            try
            {
                #region CONFIGURAÇÕES JSON
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                settings.DefaultValueHandling = DefaultValueHandling.Ignore;
                #endregion

                var documentreferences = await invoices.GetDocumentReferences(invoices);

                Invoices invoice = new Invoices();
                invoice.DocumentLines = new List<DocumentLine>();
                invoice.DocumentInstallments = new List<Documentinstallment>();
                invoice.DocumentReferences = new List<Documentreference>();

                invoice.CardCode = invoices.CardCode;
                invoice.BPL_IDAssignedToInvoice = invoices.BPL_IDAssignedToInvoice;
                invoice.SequenceCode = invoices.SequenceCode;
                invoice.SequenceSerial = invoices.SequenceSerial;
                invoice.SeriesString = invoices.SeriesString;
                invoice.SequenceModel = invoices.SequenceModel;
                invoice.NumAtCard = invoices.NumAtCard;
                invoice.PaymentGroupCode = invoices.PaymentGroupCode;
                invoice.PaymentMethod = invoices.PaymentMethod;
                invoice.DocDate = invoices.DocDate;
                invoice.TaxDate = invoices.TaxDate;

                invoice.TaxExtension = new Taxextension();
                invoice.TaxExtension.MainUsage = invoices.TaxExtension.MainUsage;

                invoice.TaxExtension.NFRef = $"{GetSerialFromCte(documentreferences)}";

                foreach (var item in invoices.DocumentLines)
                {
                    DocumentLine line = new DocumentLine();

                    line.ItemCode = item.ItemCode;
                    line.Quantity = item.Quantity;
                    line.Price = item.Price;
                    line.WarehouseCode = item.WarehouseCode;
                    line.TaxCode = item.TaxCode;
                    line.FreeText = item.FreeText;

                    invoice.DocumentLines.Add(line);
                }

                foreach (var item in invoices.DocumentInstallments)
                {
                    Documentinstallment documentinstallment = new Documentinstallment();

                    documentinstallment.DueDate = item.DueDate;
                    documentinstallment.Total = item.Total;

                    invoice.DocumentInstallments.Add(documentinstallment);
                }

                foreach (var item in documentreferences)
                {
                    Documentreference documentreference = new Documentreference();

                    documentreference.RefObjType = "rot_SalesInvoice";
                    documentreference.RefDocEntr = item.RefDocEntr;
                    documentreference.RefDocNum = item.RefDocNum;

                    invoice.DocumentReferences.Add(documentreference);
                }

                try
                {
                    string jsonEnvio = JsonConvert.SerializeObject(invoice, settings);

                    var createdInvoice = await SL.Connection.Request("Invoices").WithJsonSerializerSettings(settings).PostAsync<Invoices>(invoice);

                    log = new B2F_LOG();
                    log.B2F_IdDoc = invoices.SequenceSerial.ToString() ?? string.Empty;
                    log.B2F_TipoDoc = "Invoices";
                    log.B2F_Status = "2";
                    log.B2F_IdRet = "201";
                    log.B2F_JsonEnv = invoices;
                    log.B2F_JsonRet = createdInvoice;
                    log.B2F_DtInteg = DateTime.Now.ToString("yyyy-MM-dd");
                    log.B2F_MsgRet = $"Criada com sucesso, {GetSerialFromCte(documentreferences)}";
                    log.InsertOrUpdateLog();

                    return createdInvoice;
                }
                catch (Exception ex)
                {
                    try
                    {
                        invoice.ClearDocumentReferences();
                        string jsonEnvio = JsonConvert.SerializeObject(invoice, settings);
                        var resendInvoice = await SL.Connection.Request("Invoices").WithJsonSerializerSettings(settings).PostAsync<Invoices>(invoice);

                        log = new B2F_LOG();
                        log.B2F_IdDoc = invoices.SequenceSerial.ToString() ?? string.Empty;
                        log.B2F_TipoDoc = "Invoices";
                        log.B2F_Status = "2";
                        log.B2F_IdRet = "201";
                        log.B2F_JsonEnv = invoices;
                        log.B2F_JsonRet = resendInvoice;
                        log.B2F_DtInteg = DateTime.Now.ToString("yyyy-MM-dd");
                        log.B2F_MsgRet = $"Criada com sucesso, CT-es não vinculados: {GetSerialFromCte(documentreferences)}";
                        log.InsertOrUpdateLog();

                        return resendInvoice;
                    }
                    catch (Exception)
                    {
                        log = new B2F_LOG();
                        log.B2F_IdDoc = invoices.SequenceSerial.ToString() ?? string.Empty;
                        log.B2F_TipoDoc = "Invoices";
                        log.B2F_Status = "3";
                        log.B2F_IdRet = "400";
                        log.B2F_JsonEnv = invoices;
                        log.B2F_JsonRet = ex.Message;
                        log.B2F_DtInteg = DateTime.Now.ToString("yyyy-MM-dd");
                        log.B2F_MsgRet = $"Erro ao criar: {ex.Message}";
                        log.InsertOrUpdateLog();

                        throw new Exception(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<List<Invoices>> GetAll()
        {
            try
            {
                var invoices = await SL.Connection.Request("Invoices").GetAllAsync<Invoices>();

                return invoices.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task<Invoices> Get(int docEntry)
        {
            try
            {
                var invoice = await SL.Connection.Request($"Invoices({docEntry})").GetAsync<Invoices>();

                return invoice;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static async Task Patch(int docEntry, Invoices invoice)
        {
            try
            {
                #region CONFIGURAÇÕES JSON
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                settings.DefaultValueHandling = DefaultValueHandling.Ignore;
                #endregion

                string teste = JsonConvert.SerializeObject(invoice, settings);

                await SL.Connection.Request($"Invoices({docEntry})").WithJsonSerializerSettings(settings).PatchAsync(invoice);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<Documentreference>> GetDocumentReferences(Invoices invoices)
        {
            try
            {
                B2F_LOG log = new B2F_LOG();
                DocumentReferences = new List<Documentreference>();

                foreach (var item in invoices.DocumentLines)
                {
                    string freeText = item.FreeText ?? string.Empty;

                    if (string.IsNullOrEmpty(freeText)) throw new Exception("É necessário o preenchimento da propriedade DocumentLines.FreeText");

                    if (freeText.Contains("/"))
                    {
                        string[] parts = freeText.Split('/');

                        foreach (string part in parts)
                        {
                            Documentreference docRef = new Documentreference();

                            var cte = await SL.Connection.Request("Invoices").Filter($"CardCode eq '{invoices.CardCode}' and SequenceSerial eq {Convert.ToInt32(part)}").GetAllAsync<Invoices>();

                            if (cte.Any())
                            {
                                docRef.RefDocEntr = cte.First().DocEntry;
                                docRef.RefDocNum = cte.First().DocNum;
                                docRef.Number = cte.First().SequenceSerial;
                                DocumentReferences.Add(docRef);
                            }
                            else
                            {
                                log = new B2F_LOG();
                                log.B2F_IdDoc = $"{invoices.SequenceSerial}|{part}";
                                log.B2F_TipoDoc = "Invoices";
                                log.B2F_Status = "3";
                                log.B2F_IdRet = "404";
                                log.B2F_JsonEnv = invoices;
                                log.B2F_DtInteg = DateTime.Now.ToString("yyyy-MM-dd");
                                log.B2F_MsgRet = $"CT-e não encontrado: {part}";
                                log.InsertOrUpdateLog();
                            }
                        }
                    }
                    else
                    {
                        Documentreference docRef = new Documentreference();

                        var cte = await SL.Connection.Request("Invoices").Filter($"CardCode eq '{invoices.CardCode}' and SequenceSerial eq {Convert.ToInt32(freeText)}").GetAllAsync<Invoices>();

                        if (cte.Any())
                        {
                            docRef.RefDocEntr = cte.First().DocEntry;
                            docRef.RefDocNum = cte.First().DocNum;
                            docRef.Number = cte.First().SequenceSerial;
                            DocumentReferences.Add(docRef);
                        }
                        else
                        {
                            log = new B2F_LOG();
                            log.B2F_IdDoc = $"{invoices.SequenceSerial}|{freeText}";
                            log.B2F_TipoDoc = "Invoices";
                            log.B2F_Status = "2";
                            log.B2F_IdRet = "201";
                            log.B2F_JsonEnv = invoices;
                            log.B2F_DtInteg = DateTime.Now.ToString("yyyy-MM-dd");
                            log.B2F_MsgRet = $"Erro ao criar";
                            log.InsertOrUpdateLog();
                        }
                    }
                }

                return DocumentReferences.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar CT-e, detalhes: {ex.Message}");
            }
        }

        public static string GetSerialFromCte(List<Documentreference> documentreference)
        {
            var docNums = documentreference.Select(docRef => docRef.Number);

            if (docNums.Count() > 1)
            {
                string docNumsString = string.Join(",", docNums);
                return $"CT-es nºs: {docNumsString}";
            }
            else if (docNums.Count() == 1)
            {
                return $"CT-es nº: {docNums.First()}";
            }
            else
            {
                return string.Empty;
            }
        }

        public static string GetFreeText(List<DocumentLine> documentLines)
        {
            var freeTexts = documentLines.Select(x => x.FreeText);

            string concatenatedText = "Texto livre: " + string.Join(",", freeTexts);

            return concatenatedText;
        }

        public void ClearDocumentReferences()
        {
            DocumentReferences = null;
        }
    }

    public class Taxextension
    {
        public string? TaxId0 { get; set; }
        public string? TaxId1 { get; set; }
        public string? TaxId2 { get; set; }
        public string? TaxId3 { get; set; }
        public string? TaxId4 { get; set; }
        public string? TaxId5 { get; set; }
        public string? TaxId6 { get; set; }
        public string? TaxId7 { get; set; }
        public string? TaxId8 { get; set; }
        public object? TaxId9 { get; set; }
        public string? State { get; set; }
        public string? County { get; set; }
        public object? Incoterms { get; set; }
        public object? Vehicle { get; set; }
        public object? VehicleState { get; set; }
        public string? NFRef { get; set; }
        public object? Carrier { get; set; }
        public object? PackQuantity { get; set; }
        public object? PackDescription { get; set; }
        public object? Brand { get; set; }
        public object? ShipUnitNo { get; set; }
        public float? NetWeight { get; set; }
        public float? GrossWeight { get; set; }
        public object? StreetS { get; set; }
        public string? BlockS { get; set; }
        public object? BuildingS { get; set; }
        public string? CityS { get; set; }
        public string? ZipCodeS { get; set; }
        public string? CountyS { get; set; }
        public string? StateS { get; set; }
        public string? CountryS { get; set; }
        public object? StreetB { get; set; }
        public object? BlockB { get; set; }
        public object? BuildingB { get; set; }
        public object? CityB { get; set; }
        public object? ZipCodeB { get; set; }
        public string? CountyB { get; set; }
        public string? StateB { get; set; }
        public string? CountryB { get; set; }
        public object? ImportOrExport { get; set; }
        public int? MainUsage { get; set; }
        public object? GlobalLocationNumberS { get; set; }
        public object? GlobalLocationNumberB { get; set; }
        public string? TaxId12 { get; set; }
        public object? TaxId13 { get; set; }
        public object? BillOfEntryNo { get; set; }
        public object? BillOfEntryDate { get; set; }
        public object? OriginalBillOfEntryNo { get; set; }
        public object? OriginalBillOfEntryDate { get; set; }
        public string? ImportOrExportType { get; set; }
        public object? PortCode { get; set; }
        public int? DocEntry { get; set; }
        public float? BoEValue { get; set; }
        public object? ClaimRefund { get; set; }
        public object? DifferentialOfTaxRate { get; set; }
        public string? IsIGSTAccount { get; set; }
    }

    public class Addressextension
    {
        public object? ShipToStreet { get; set; }
        public string? ShipToStreetNo { get; set; }
        public string? ShipToBlock { get; set; }
        public object? ShipToBuilding { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToZipCode { get; set; }
        public string? ShipToCounty { get; set; }
        public string? ShipToState { get; set; }
        public string? ShipToCountry { get; set; }
        public object? ShipToAddressType { get; set; }
        public object? BillToStreet { get; set; }
        public object? BillToStreetNo { get; set; }
        public object? BillToBlock { get; set; }
        public object? BillToBuilding { get; set; }
        public object? BillToCity { get; set; }
        public object? BillToZipCode { get; set; }
        public string? BillToCounty { get; set; }
        public string? BillToState { get; set; }
        public string? BillToCountry { get; set; }
        public object? BillToAddressType { get; set; }
        public object? ShipToGlobalLocationNumber { get; set; }
        public object? BillToGlobalLocationNumber { get; set; }
        public object? ShipToAddress2 { get; set; }
        public object? ShipToAddress3 { get; set; }
        public object? BillToAddress2 { get; set; }
        public object? BillToAddress3 { get; set; }
        public object? PlaceOfSupply { get; set; }
        public object? PurchasePlaceOfSupply { get; set; }
        public int? DocEntry { get; set; }
        public object? GoodsIssuePlaceBP { get; set; }
        public object? GoodsIssuePlaceCNPJ { get; set; }
        public object? GoodsIssuePlaceCPF { get; set; }
        public object? GoodsIssuePlaceStreet { get; set; }
        public object? GoodsIssuePlaceStreetNo { get; set; }
        public object? GoodsIssuePlaceBuilding { get; set; }
        public object? GoodsIssuePlaceZip { get; set; }
        public object? GoodsIssuePlaceBlock { get; set; }
        public object? GoodsIssuePlaceCity { get; set; }
        public object? GoodsIssuePlaceCounty { get; set; }
        public object? GoodsIssuePlaceState { get; set; }
        public object? GoodsIssuePlaceCountry { get; set; }
        public object? GoodsIssuePlacePhone { get; set; }
        public object? GoodsIssuePlaceEMail { get; set; }
        public object? GoodsIssuePlaceDepartureDate { get; set; }
        public object? DeliveryPlaceBP { get; set; }
        public object? DeliveryPlaceCNPJ { get; set; }
        public object? DeliveryPlaceCPF { get; set; }
        public object? DeliveryPlaceStreet { get; set; }
        public object? DeliveryPlaceStreetNo { get; set; }
        public object? DeliveryPlaceBuilding { get; set; }
        public object? DeliveryPlaceZip { get; set; }
        public object? DeliveryPlaceBlock { get; set; }
        public object? DeliveryPlaceCity { get; set; }
        public object? DeliveryPlaceCounty { get; set; }
        public object? DeliveryPlaceState { get; set; }
        public object? DeliveryPlaceCountry { get; set; }
        public object? DeliveryPlacePhone { get; set; }
        public object? DeliveryPlaceEMail { get; set; }
        public object? DeliveryPlaceDepartureDate { get; set; }
        public object? U_TX_IES { get; set; }
        public object? U_TX_IEB { get; set; }
    }

    public class DocumentLine
    {
        public int? LineNum { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescription { get; set; }
        public float? Quantity { get; set; }
        public object? ShipDate { get; set; }
        public float? Price { get; set; }
        public float? PriceAfterVAT { get; set; }
        public string? Currency { get; set; }
        public float? Rate { get; set; }
        public float? DiscountPercent { get; set; }
        public object? VendorNum { get; set; }
        public string? SerialNum { get; set; }
        public string? WarehouseCode { get; set; }
        public int? SalesPersonCode { get; set; }
        public float? CommisionPercent { get; set; }
        public string? TreeType { get; set; }
        public string? AccountCode { get; set; }
        public string? UseBaseUnits { get; set; }
        public string? SupplierCatNum { get; set; }
        public object? CostingCode { get; set; }
        public string? ProjectCode { get; set; }
        public string? BarCode { get; set; }
        public object? VatGroup { get; set; }
        public float? Height1 { get; set; }
        public object? Hight1Unit { get; set; }
        public float? Height2 { get; set; }
        public object? Height2Unit { get; set; }
        public float? Lengh1 { get; set; }
        public object? Lengh1Unit { get; set; }
        public float? Lengh2 { get; set; }
        public object? Lengh2Unit { get; set; }
        public float? Weight1 { get; set; }
        public object? Weight1Unit { get; set; }
        public float? Weight2 { get; set; }
        public object? Weight2Unit { get; set; }
        public float? Factor1 { get; set; }
        public float? Factor2 { get; set; }
        public float? Factor3 { get; set; }
        public float? Factor4 { get; set; }
        public int? BaseType { get; set; }
        public object? BaseEntry { get; set; }
        public object? BaseLine { get; set; }
        public float? Volume { get; set; }
        public int? VolumeUnit { get; set; }
        public float? Width1 { get; set; }
        public object? Width1Unit { get; set; }
        public float? Width2 { get; set; }
        public object? Width2Unit { get; set; }
        public string? Address { get; set; }
        public string? TaxCode { get; set; }
        public string? TaxType { get; set; }
        public string? TaxLiable { get; set; }
        public string? PickStatus { get; set; }
        public float? PickQuantity { get; set; }
        public object? PickListIdNumber { get; set; }
        public object? OriginalItem { get; set; }
        public object? BackOrder { get; set; }
        public string? FreeText { get; set; }
        public int? ShippingMethod { get; set; }
        public object? POTargetNum { get; set; }
        public string? POTargetEntry { get; set; }
        public object? POTargetRowNum { get; set; }
        public string? CorrectionInvoiceItem { get; set; }
        public float? CorrInvAmountToStock { get; set; }
        public float? CorrInvAmountToDiffAcct { get; set; }
        public float? AppliedTax { get; set; }
        public float? AppliedTaxFC { get; set; }
        public float? AppliedTaxSC { get; set; }
        public string? WTLiable { get; set; }
        public string? DeferredTax { get; set; }
        public float? EqualizationTaxPercent { get; set; }
        public float? TotalEqualizationTax { get; set; }
        public float? TotalEqualizationTaxFC { get; set; }
        public float? TotalEqualizationTaxSC { get; set; }
        public float? NetTaxAmount { get; set; }
        public float? NetTaxAmountFC { get; set; }
        public float? NetTaxAmountSC { get; set; }
        public string? MeasureUnit { get; set; }
        public float? UnitsOfMeasurment { get; set; }
        public float? LineTotal { get; set; }
        public float? TaxPercentagePerRow { get; set; }
        public float? TaxTotal { get; set; }
        public string? ConsumerSalesForecast { get; set; }
        public float? ExciseAmount { get; set; }
        public float? TaxPerUnit { get; set; }
        public float? TotalInclTax { get; set; }
        public object? CountryOrg { get; set; }
        public object? SWW { get; set; }
        public object? TransactionType { get; set; }
        public string? DistributeExpense { get; set; }
        public float? RowTotalFC { get; set; }
        public float? RowTotalSC { get; set; }
        public float? LastBuyInmPrice { get; set; }
        public float? LastBuyDistributeSumFc { get; set; }
        public float? LastBuyDistributeSumSc { get; set; }
        public float? LastBuyDistributeSum { get; set; }
        public float? StockDistributesumForeign { get; set; }
        public float? StockDistributesumSystem { get; set; }
        public float? StockDistributesum { get; set; }
        public float? StockInmPrice { get; set; }
        public string? PickStatusEx { get; set; }
        public float? TaxBeforeDPM { get; set; }
        public float? TaxBeforeDPMFC { get; set; }
        public float? TaxBeforeDPMSC { get; set; }
        public string? CFOPCode { get; set; }
        public string? CSTCode { get; set; }
        public object? Usage { get; set; }
        public string? TaxOnly { get; set; }
        public int? VisualOrder { get; set; }
        public float? BaseOpenQuantity { get; set; }
        public float? UnitPrice { get; set; }
        public string? LineStatus { get; set; }
        public float? PackageQuantity { get; set; }
        public object? Text { get; set; }
        public string? LineType { get; set; }
        public object? COGSCostingCode { get; set; }
        public string? COGSAccountCode { get; set; }
        public string? ChangeAssemlyBoMWarehouse { get; set; }
        public float? GrossBuyPrice { get; set; }
        public int? GrossBase { get; set; }
        public float? GrossProfitTotalBasePrice { get; set; }
        public object? CostingCode2 { get; set; }
        public object? CostingCode3 { get; set; }
        public object? CostingCode4 { get; set; }
        public object? CostingCode5 { get; set; }
        public object? ItemDetails { get; set; }
        public object? LocationCode { get; set; }
        public string? ActualDeliveryDate { get; set; }
        public float? RemainingOpenQuantity { get; set; }
        public float? OpenAmount { get; set; }
        public float? OpenAmountFC { get; set; }
        public float? OpenAmountSC { get; set; }
        public object? ExLineNo { get; set; }
        public object? RequiredDate { get; set; }
        public float? RequiredQuantity { get; set; }
        public object? COGSCostingCode2 { get; set; }
        public object? COGSCostingCode3 { get; set; }
        public object? COGSCostingCode4 { get; set; }
        public object? COGSCostingCode5 { get; set; }
        public string? CSTforIPI { get; set; }
        public string? CSTforPIS { get; set; }
        public string? CSTforCOFINS { get; set; }
        public string? CreditOriginCode { get; set; }
        public string? WithoutInventoryMovement { get; set; }
        public object? AgreementNo { get; set; }
        public object? AgreementRowNumber { get; set; }
        public object? ActualBaseEntry { get; set; }
        public object? ActualBaseLine { get; set; }
        public int? DocEntry { get; set; }
        public float? Surpluses { get; set; }
        public float? DefectAndBreakup { get; set; }
        public float? Shortages { get; set; }
        public string? ConsiderQuantity { get; set; }
        public string? PartialRetirement { get; set; }
        public float? RetirementQuantity { get; set; }
        public float? RetirementAPC { get; set; }
        public string? ThirdParty { get; set; }
        public object? PoNum { get; set; }
        public object? PoItmNum { get; set; }
        public object? ExpenseType { get; set; }
        public object? ReceiptNumber { get; set; }
        public object? ExpenseOperationType { get; set; }
        public object? FederalTaxID { get; set; }
        public float? GrossProfit { get; set; }
        public float? GrossProfitFC { get; set; }
        public float? GrossProfitSC { get; set; }
        public string? PriceSource { get; set; }
        public object? StgSeqNum { get; set; }
        public object? StgEntry { get; set; }
        public object? StgDesc { get; set; }
        public int? UoMEntry { get; set; }
        public string? UoMCode { get; set; }
        public float? InventoryQuantity { get; set; }
        public float? RemainingOpenInventoryQuantity { get; set; }
        public object? ParentLineNum { get; set; }
        public int? Incoterms { get; set; }
        public int? TransportMode { get; set; }
        public object? NatureOfTransaction { get; set; }
        public object? DestinationCountryForImport { get; set; }
        public object? DestinationRegionForImport { get; set; }
        public object? OriginCountryForExport { get; set; }
        public object? OriginRegionForExport { get; set; }
        public string? ItemType { get; set; }
        public string? ChangeInventoryQuantityIndependently { get; set; }
        public string? FreeOfChargeBP { get; set; }
        public object? SACEntry { get; set; }
        public object? HSNEntry { get; set; }
        public float? GrossPrice { get; set; }
        public float? GrossTotal { get; set; }
        public float? GrossTotalFC { get; set; }
        public float? GrossTotalSC { get; set; }
        public int? NCMCode { get; set; }
        public object? NVECode { get; set; }
        public string? IndEscala { get; set; }
        public float? CtrSealQty { get; set; }
        public object? CNJPMan { get; set; }
        public object? CESTCode { get; set; }
        public object? UFFiscalBenefitCode { get; set; }
        public string? ReverseCharge { get; set; }
        public string? ShipToCode { get; set; }
        public string? ShipToDescription { get; set; }
        public float? ExternalCalcTaxRate { get; set; }
        public float? ExternalCalcTaxAmount { get; set; }
        public float? ExternalCalcTaxAmountFC { get; set; }
        public float? ExternalCalcTaxAmountSC { get; set; }
        public object? StandardItemIdentification { get; set; }
        public object? CommodityClassification { get; set; }
        public object? UnencumberedReason { get; set; }
        public string? CUSplit { get; set; }
        public Linetaxjurisdiction[]? LineTaxJurisdictions { get; set; }
        public Exportprocess[]? ExportProcesses { get; set; }
        public object[]? EBooksDetails { get; set; }
        public object[]? DocumentLineAdditionalExpenses { get; set; }
        public object[]? WithholdingTaxLines { get; set; }
        public object[]? SerialNumbers { get; set; }
        public object[]? BatchNumbers { get; set; }
        public object[]? CCDNumbers { get; set; }
        public object[]? DocumentLinesBinAllocations { get; set; }
    }

    public class Linetaxjurisdiction
    {
        public string? JurisdictionCode { get; set; }
        public int? JurisdictionType { get; set; }
        public float? TaxAmount { get; set; }
        public float? TaxAmountSC { get; set; }
        public float? TaxAmountFC { get; set; }
        public float? TaxRate { get; set; }
        public int? DocEntry { get; set; }
        public int? LineNumber { get; set; }
        public int? RowSequence { get; set; }
        public float? ExternalCalcTaxRate { get; set; }
        public float? ExternalCalcTaxAmount { get; set; }
        public float? ExternalCalcTaxAmountFC { get; set; }
        public float? ExternalCalcTaxAmountSC { get; set; }
    }

    public class Exportprocess
    {
        public int? LineNumber { get; set; }
        public int? ExportationDocumentTypeCode { get; set; }
        public object? ExportationDeclarationNumber { get; set; }
        public object? ExportationDeclarationDate { get; set; }
        public int? ExportationNatureCode { get; set; }
        public object? ExportationRegistryNumber { get; set; }
        public object? ExportationRegistryDate { get; set; }
        public object? LadingBillNumber { get; set; }
        public object? LadingBillDate { get; set; }
        public object? MerchandiseLeftCustomsDate { get; set; }
        public int? LadingBillTypeCode { get; set; }
        public object? DrawbackSuspensionRegime { get; set; }
        public object? NatureOfExport { get; set; }
        public float? QuantityOfExportedItems { get; set; }
        public object? AdditionalItemSequentialNumber { get; set; }
    }

    public class Documentinstallment
    {
        public string? DueDate { get; set; }
        public float? Percentage { get; set; }
        public float? Total { get; set; }
        public object? LastDunningDate { get; set; }
        public int? DunningLevel { get; set; }
        public object? TotalFC { get; set; }
        public int? InstallmentId { get; set; }
        public string? PaymentOrdered { get; set; }
    }

    public class Documentreference
    {
        public int? DocEntry { get; set; }
        public int? LineNumber { get; set; }
        public int? RefDocEntr { get; set; }
        public int? RefDocNum { get; set; }
        public string? ExtDocNum { get; set; }
        public string? RefObjType { get; set; }
        public object? AccessKey { get; set; }
        public string? IssueDate { get; set; }
        public string? IssuerCNPJ { get; set; }
        public string? IssuerCode { get; set; }
        public string? Model { get; set; }
        public string? Series { get; set; }
        public int? Number { get; set; }
        public string? RefAccKey { get; set; }
        public float? RefAmount { get; set; }
        public object? SubSeries { get; set; }
        public object? Remark { get; set; }
        public string? LinkRefTyp { get; set; }
    }
}
