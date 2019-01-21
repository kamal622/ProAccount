using ProAccount.Core;
using ProAccount.Forms;
using System;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;

public static class CommonModule
{
    public static int mId = 0;
    public static bool IsFormClear = false;

    public static void ShowSearchengine(object Req_Ctrl, 
                                        string Req_Qry,
                                        short Req_Fieldno, 
                                        string Def_Filterfield, 
                                        string tblName, 
                                        string Req_Colwidth = "", 
                                        string Req_Orderbyfield = "", 
                                        short Def_Rowsdiplayed = 0)
    {
        try
        {
            var frmSearch = new SearchForm();
            frmSearch.Clear_Values();
            frmSearch.Req_Ctrl = Req_Ctrl;
            frmSearch.Req_Qry = Req_Qry;
            frmSearch.Req_Fieldno = Req_Fieldno;
            frmSearch.Def_Filterfield= Def_Filterfield;
            frmSearch.Req_Colwidth = Req_Colwidth;
            frmSearch.Req_Orderbyfield = Req_Orderbyfield;
            frmSearch.Def_Rowsdiplayed = Def_Rowsdiplayed;
            frmSearch.tblName = tblName;
            frmSearch.Search();
            frmSearch.ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, Comman.Product_Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}