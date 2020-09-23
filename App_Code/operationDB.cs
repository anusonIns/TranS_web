using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for operationDB
/// </summary>
public class operationDB
{
    public string OperationMessage { get; set; }
    public operationDB()
    {
        transec_datasetDataContext trans_db = new transec_datasetDataContext();
        var customers = trans_db.ExecuteQuery<TransectionDB>(@"SELECT  * FROM   TransectionDB ");

        foreach (var c in customers)
        {
        }
    }
    public bool InsertTransection(TransectionDB tb)
    {
        try
        {
            using (transec_datasetDataContext dc = new transec_datasetDataContext())
            {
                TransectionDB objEmp = new TransectionDB();
                objEmp.Id = tb.Id;
                objEmp.Transaction_Id = tb.Transaction_Id;
                objEmp.Amount = tb.Amount;
                objEmp.Currency_Code = tb.Currency_Code;
                objEmp.Transaction_Date =tb.Transaction_Date;
                objEmp.Status = tb.Status;
                dc.TransectionDBs.InsertOnSubmit(objEmp);
                dc.SubmitChanges();
            }
            OperationMessage = "Inserted.";
            return true;
        }
        catch(Exception ex)
        {
            OperationMessage = ex.Message;
            return false;
        }
    }
}