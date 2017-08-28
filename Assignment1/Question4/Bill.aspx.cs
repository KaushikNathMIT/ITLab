using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bill : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		TableRow tableRow = new TableRow();
		string text;
		addNewCell(tableRow, "Item");
		addNewCell(tableRow, "Quantity");
		addNewCell(tableRow, "Price");
		bill_table.Rows.Add(tableRow);
	}

	private void addNewCell(TableRow tableRow, string text) {
		TableCell tableCell = new TableCell();
		tableCell.Text = text;
		tableRow.Cells.Add(tableCell);
	}
}