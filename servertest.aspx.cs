using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class servertest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int intCols = 3;
        int intRows = 4;

        Table tbl = new Table();
        tbl.GridLines = GridLines.Both;
        PlaceHolder1.Controls.Add(tbl);

        //rows
        for (int i = 0; i <= intRows; i++)
        {
            TableRow tr = new TableRow();
            //cols
            for (int j = 0; j <= intCols; j++)
            {
                TableCell td = new TableCell();
                td.Text = "RowNo " + i + " ColunmNo " + j + " ";
                tr.Cells.Add(td);


            }
            tbl.Rows.Add(tr);


        }
   }
}
