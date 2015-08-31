import com.itextpdf.text.BaseColor;
import com.itextpdf.text.Document;
import com.itextpdf.text.Font;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.pdf.BaseFont;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;

import java.io.FileOutputStream;

public class GenerateAPDFbyExternalLibrary {
	public static void main(String[] args) {
		try {
			Document document = new Document();
			PdfWriter.getInstance(document, new FileOutputStream("Deck-of-Cards.pdf"));
			document.open();

			PdfPTable table = new PdfPTable(4);
			table.setWidthPercentage(100);
			table.getDefaultCell().setFixedHeight(150);

			BaseFont baseFont = BaseFont.createFont("c:/windows/fonts/arialbd.ttf",BaseFont.IDENTITY_H,BaseFont.EMBEDDED);
			Font black = new Font(baseFont, 65f, 0, BaseColor.BLACK);
			Font red = new Font(baseFont, 65f, 0, BaseColor.RED);

			char[] suits = { '\u2663', '\u2666', '\u2665', '\u2660' };
			String card = "";
            String color = "";
            
			for (int i = 2; i <= 14; i++) {
				switch (i) {
                case 10: card = "10"; break;
                case 11: card = " J"; break;
                case 12: card = " Q"; break;
                case 13: card = " K"; break;
                case 14: card = " A"; break;
                default: card = " " + i; break;
				}
				
				for (int j = 0; j < 4; j++) {
					if (j == 0 || j ==3) {
						table.addCell(new Paragraph("" + card + suits[j], black));
					}
					else {
						table.addCell(new Paragraph("" + card + suits[j], red));
					}
				}
			}
			
			document.add(table);
			document.close();

		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
