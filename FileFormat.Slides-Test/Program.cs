﻿
using FileFormat.Slides;
using FileFormat.Slides.Common;
using System.Collections.Generic;




class Program
    {
    public const string PPT_FILE_PATH = Constants.OUTPUT_DIR + Constants.PPT_FILE;
    static void Main()
        {
        /* Create new Presentation*/
        /*
        Presentation presentation = Presentation.Create(PPT_FILE_PATH);
        TextShape shape = new TextShape();
        shape.Text = "Title: Here is my first title From FF";
        shape.TextColor = "980078";
        shape.FontFamily = "Baguet Script";
        shape.Alignment = FileFormat.Slides.Common.Enumerations.TextAlignment.Left;
        shape.Anchor = FileFormat.Slides.Common.Enumerations.TextAnchor.Top;
        TextShape shape2 = new TextShape();
        shape2.Text = "Body : Here is my first title From FF";
        shape2.FontFamily = "BIZ UDGothic";
        shape2.FontSize = 30;
        shape2.Alignment = FileFormat.Slides.Common.Enumerations.TextAlignment.Right;
        shape2.Y = FileFormat.Slides.Common.Utility.EmuToPixels(2499619);
        shape2.Anchor = FileFormat.Slides.Common.Enumerations.TextAnchor.Bottom;

        // First slide
        Slide slide = new Slide();
        slide.AddTextShapes(shape);
        slide.AddTextShapes(shape2);
        // 2nd slide
        Slide slide1 = new Slide();
        slide1.AddTextShapes(shape);
        slide1.AddTextShapes(shape2);
        // Adding slides
        presentation.AppendSlide(slide);
        presentation.AppendSlide(slide1);
        presentation.Save();
        */
        /*
        Presentation presentation = Presentation.Create(PPT_FILE_PATH);
        TextShape shape = new TextShape();
        shape.Text = "Title: Here is my first title From FF";
        shape.BackgroundColor = "5f7200";
        shape.Alignment = FileFormat.Slides.Common.Enumerations.TextAlignment.Left;
        shape.Anchor = FileFormat.Slides.Common.Enumerations.TextAnchor.Top;
        shape.FontSize = 80;
        shape.TextColor = "ffffff";
        shape.FontFamily = "Baguet Script";
        TextShape shape2 = new TextShape();

        shape2.BackgroundColor = "ff7f90";
        List<TextSegment> TextSegments = new List<TextSegment>();
        TextSegments.Add(new TextSegment { Color = "980078", FontSize = 70, FontFamily = "Calibri", Text = "Body:" }.create());
        TextSegments.Add(new TextSegment { Color = "ffffff", FontSize = 32, FontFamily = "Baguet Script", Text = " Here is my text Segment" }.create());

        shape2.Y = Utility.EmuToPixels(3499619);
        shape2.Alignment = FileFormat.Slides.Common.Enumerations.TextAlignment.Right;
        shape2.Anchor = FileFormat.Slides.Common.Enumerations.TextAnchor.Bottom;
        // First slide
        Slide slide = new Slide();
        slide.AddTextShapes(shape);
        slide.AddTextShapes(shape2, TextSegments);

        // Adding slides
        presentation.AppendSlide(slide);

        presentation.Save();
        */

        ///* 
        //Open and update a PPTX file
        Presentation presentation = Presentation.Open(PPT_FILE_PATH);
        var slides = presentation.GetSlides();
        var slide = slides[0];
        List<TextShape> shapes = slide.GetTextShapesByText("PRESENTATION");
        var shape = slide.TextShapes[0];
        //shape.X = 100000;
        //shape.Y = 100000;
        shape.Alignment = FileFormat.Slides.Common.Enumerations.TextAlignment.Center;
        shape.Text = "Test Update Text";
        shape.Update();
        presentation.Save();
        //*/

        /* 
         * Remove a slide from presentation.
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\sample.pptx");
        var confirmation = presentation.RemoveSlide(0);
        Console.WriteLine(confirmation);
        presentation.Save();
        */

        /*
         * Remove text shape from a slide
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\sample.pptx");
        var slides = presentation.GetSlides();
        var slide = slides[0];
        var shape = slide.TextShapes[0];
        shape.Remove();
        presentation.Save();
        */


        /*
         // change background of a slide of an existing presentation
         Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\test.pptx");
         TextShape shape1 = new TextShape();
         shape1.Text = "Body : Here is my first title From FF";
         shape1.FontFamily = "Baguet Script";
         shape1.TextColor = Colors.Olive;
         shape1.FontSize = 45;
         shape1.Y = 10.0;
        Slide slide = presentation.GetSlides()[1];
        slide.BackgroundColor = Colors.Silver;
        slide.Update();
        presentation.Save();
        */



        /*
         * Update an image in a slide
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\sample.pptx");
        var slides = presentation.GetSlides();
        var slide = slides[0];
        List<Image> images = slide.Images;
        var image = slide.Images[0];
        image.Width = 300.0;
        image.Height = 300.0;
        image.Update();
        presentation.Save();*/

        /*
         * Extract and save images of an existing PPTX
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\sample.pptx");
        presentation.ExtractAndSaveImages("testing images"); */


        /*
       //Update an image in a slide
       Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\sample.pptx");
       var slides = presentation.GetSlides();
       var slide = slides[0];
       var shape = slide.TextShapes[0];
        shape.BackgroundColor = "7f7f88";
        shape.Text = "Updated 2nd Text";
        shape.Update();
        Slide slide1 = new Slide();
        slide1.BackgroundColor = Colors.Green;
        Image image1 = new Image("D:\\AsposeSampleData\\target.png");
        image1.X = Utility.EmuToPixels(1838700);
        image1.Y = Utility.EmuToPixels(1285962);
        image1.Width = Utility.EmuToPixels(2514600);
        image1.Height = Utility.EmuToPixels(2886075);
        slide1.AddImage(image1);
        
        presentation.AppendSlide(slide1);
        presentation.Save();
        */
        /*
         * Add bulleted list.
        Presentation presentation = Presentation.Create("D:\\AsposeSampleResults\\test2.pptx");
        Slide slide1 = new Slide();
        slide1.BackgroundColor = Colors.Purple;
        TextShape shape1 = new TextShape();
        shape1.FontFamily = "Baguet Script";
        shape1.FontSize = 60;
        shape1.Y = 200.0;
        shape1.TextColor = Colors.Yellow;
        shape1.BackgroundColor = Colors.LimeGreen;

        StyledList list = new StyledList(FileFormat.Slides.Common.Enumerations.ListType.Bulleted);
        list.AddListItem("Pakistan");
        list.AddListItem("India");
        list.AddListItem("Australia");
        list.AddListItem("England");

        shape1.TextList = list;
        slide1.AddTextShapes(shape1);

        presentation.AppendSlide(slide1);
        presentation.Save();
        */
        /*
        // Add numbered list to an existing presentation
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\test.pptx");
        Slide slide = new Slide();
        slide.BackgroundColor = Colors.Teal;
        TextShape shape1 = new TextShape();
        shape1.FontFamily = "Baguet Script";
        shape1.FontSize = 60;
        shape1.Y = 200.0;
        shape1.TextColor = Colors.Yellow;
        shape1.BackgroundColor = Colors.LimeGreen;

        StyledList list = new StyledList(FileFormat.Slides.Common.Enumerations.ListType.Numbered);
        list.AddListItem("Umar");
        list.AddListItem("Farooq");
        list.AddListItem("Adnan");
        list.AddListItem("Usman");
        list.AddListItem("Numan");
        shape1.TextList = list;

        slide.AddTextShapes(shape1);
        presentation.AppendSlide(slide);
        presentation.Save();
        */
        /*
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\test.pptx");
        Slide slide = presentation.GetSlides()[3];
        TextShape shape = slide.TextShapes[0];
        StyledList list = shape.TextList;
        list.ListItems.RemoveAt(4);
        list.ListItems.RemoveAt(2);
        list.ListType = FileFormat.Slides.Common.Enumerations.ListType.Bulleted;
        list.Update();

        presentation.Save();
        */

        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\test.pptx");
        Slide slide = presentation.GetSlides()[2];

        // Assign values to the properties of Stylings
        Stylings stylings = new Stylings();
        stylings.FontSize = 14;
        stylings.Alignment = FileFormat.Slides.Common.Enumerations.TextAlignment.Left;
        stylings.FontFamily = "Baguet Script";
        stylings.TextColor = Colors.Red;

        Table table = new Table();

        table.TableStylings = stylings;
        TableColumn col1 = new TableColumn();
        col1.Name = "ID";
        table.Columns.Add(col1);
        TableColumn col2 = new TableColumn();
        col2.Name = "Name";
        table.Columns.Add(col2);
        TableColumn col3 = new TableColumn();
        col3.Name = "City";
        table.Columns.Add(col3);
        //1st row
        // Assign values to the properties of Stylings
        Stylings rowstylings = new Stylings();
        rowstylings.FontSize = 14;
        rowstylings.Alignment = FileFormat.Slides.Common.Enumerations.TextAlignment.Left;
        rowstylings.FontFamily = "Baguet Script";
        rowstylings.TextColor = Colors.Green;
        TableRow row1 = new TableRow(table);
        row1.RowStylings = rowstylings;
        TableCell cell11 = new TableCell(row1);
        cell11.Text = "907";
        cell11.ID = col1.Name;
        row1.AddCell(cell11);
        TableCell cell12 = new TableCell(row1);
        cell12.Text = "John";
        cell12.ID = col2.Name;
        row1.AddCell(cell12);
        TableCell cell13 = new TableCell(row1);
        cell13.Text = "Chicago";
        cell13.ID = col3.Name;
        row1.AddCell(cell13);
        table.AddRow(row1);           
        
        //2nd Row
        TableRow row2 = new TableRow(table);
        TableCell cell21 = new TableCell(row2); 
        cell21.Text = "908";
        cell21.ID = col1.Name;
        row2.AddCell(cell21);
        TableCell cell22 = new TableCell(row2);
        cell22.Text = "Chris";
        cell22.ID = col2.Name;
        row2.AddCell(cell22);
        TableCell cell23 = new TableCell(row2);
        cell23.Text = "New York";
        cell23.ID = col3.Name;
        row2.AddCell(cell23);
        table.AddRow(row2);

        table.Width = 500.0;
        table.Height = 200.0;
        table.X = 300.0;
        table.Y = 500.0;
        slide.AddTable(table);

        presentation.Save();*/

        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\test.pptx");
        Slide slide = presentation.GetSlides()[0];

        Table table = slide.Tables[0];
        table.Theme = Table.TableStyle.LightStyle3;
        TableRow row2 = new TableRow(table);
        TableCell cell21 = new TableCell(row2);
        cell21.Text = "915";
        cell21.ID = table.Columns[0].Name;
        row2.AddCell(cell21);
        TableCell cell22 = new TableCell(row2);
        cell22.Text = "Allen";
        cell22.ID = table.Columns[1].Name;
        row2.AddCell(cell22);
        TableCell cell23 = new TableCell(row2);
        cell23.Text = "New York";
        cell23.ID = table.Columns[2].Name;
        row2.AddCell(cell23);
        
        table.AddRow(row2);
        table.Update();

        presentation.Save();*/

        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\test.pptx");
        Slide slide = presentation.GetSlides()[0];

        Table table = slide.Tables[0];
        TableColumn col3 = new TableColumn();
        col3.Name = "City";
        table.Columns.Add(col3);
        // Create a new cell for the new column
        TableCell newCell1 = new TableCell();
        newCell1.Text = "Chicago";
        newCell1.ID = col3.Name;
        table.Rows[0].AddCell(newCell1);

        TableCell newCell2 = new TableCell();
        newCell2.ID = col3.Name;
        newCell2.Text = "New York";
        table.Rows[1].AddCell(newCell2);

        TableCell newCell3 = new TableCell();
        newCell3.ID = col3.Name;
        newCell3.Text = "Chicago";
        table.Rows[2].AddCell(newCell3);

        TableCell newCell4 = new TableCell();
        newCell4.ID = col3.Name;
        newCell4.Text = "California";
        table.Rows[3].AddCell(newCell4);

        table.Update();

        presentation.Save();*/
        /*  
        Presentation presentation = Presentation.Create("D:\\AsposeSampleResults\\comment.pptx");
        CommentAuthor author = new CommentAuthor();
        author.Name= "umar";
        author.InitialLetter = "u";
        author.ColorIndex = 2;
        author.Id = 1;
        presentation.CreateAuthor(author);
        CommentAuthor author2 = new CommentAuthor();
        author2.Name = "hp";
        author2.InitialLetter = "h";
        author2.ColorIndex = 3;
        author2.Id = 2;
        presentation.CreateAuthor(author2);

        Slide slide1 = new Slide();
        slide1.SlidePresentation = presentation;
        Comment comment1 = new Comment();
        comment1.AuthorId = presentation.GetCommentAuthors()[0].Id;
        comment1.Text = "First programmatic comment";
        comment1.InsertedAt=DateTime.Now;
        Comment comment2 = new Comment();
        comment2.AuthorId = presentation.GetCommentAuthors()[1].Id;
        comment2.Text = "2nd programmatic comment";
        comment2.InsertedAt = DateTime.Now;
        slide1.AddComment(comment1);
        slide1.AddComment(comment2);
        presentation.AppendSlide(slide1);
       // presentation.RemoveCommentAuthor(presentation.GetCommentAuthors()[0]);

        presentation.Save();
        */
        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\comment.pptx");
         Slide slide = presentation.GetSlides()[0];
         var comments=slide.GetComments();
         comments[0].Remove();
         presentation.Save();*/

        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\comment.pptx");
        Slide slide = presentation.GetSlides()[0];
        Comment comment1 = new Comment();
        comment1.AuthorId = presentation.GetCommentAuthors()[1].Id;
        comment1.Text = "2nd Programmatic comment in an existing presentation";
        comment1.InsertedAt = DateTime.Now;
       
        slide.AddComment(comment1);
        presentation.Save();
        */
        /*
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\test.pptx");
        Slide slide = presentation.GetSlides()[0];
      
        //slide.AddNote("Serious Note");
        //presentation.GetSlides()[1].AddNote("Light Note");
        //presentation.SaveAllNotesToTextFile("D:\\AsposeSampleData\\Notes.txt");
        presentation.Save();*/

        /* Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
         Slide slide = new Slide();

         Triangle triangle = new Triangle();
         triangle.Width = 500.0;
         triangle.Height =300.0;
         triangle.X = triangle.Width / 2;
         triangle.Y = triangle.Height / 2;
         triangle.BackgroundColor = "5f7200";
         slide.DrawTriangle(triangle);
         presentation.AppendSlide(slide);
         presentation.Save();*/

        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        Slide slide = new Slide();
        
        Diamond diamond = new Diamond();
        diamond.Width = 500.0;
        diamond.Height = 300.0;
        diamond.X = diamond.Width / 2;
        diamond.Y = diamond.Height / 2;
        diamond.BackgroundColor = "5f7200";
        slide.DrawDiamond(diamond);
        presentation.AppendSlide(slide);
        presentation.Save();*/

        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        Slide slide = new Slide();

        Line line = new Line();
        line.Width = 300.0;
        line.Height = 50.0;
        line.X = line.Width / 2;
        line.Y = line.Height + 200 / 2;
        slide.DrawLine(line);
        presentation.AppendSlide(slide);
        presentation.Save();*/
        /*
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        Slide slide = new Slide();

        Arrow arrow = new Arrow();
        arrow.Width = 300.0;
        arrow.Height = 50.0;
        arrow.X = arrow.Width / 2;
        arrow.Y = arrow.Height + 200 / 2;
        slide.DrawArrow(arrow);
        presentation.AppendSlide(slide);
        presentation.Save();
        */
        /*
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        Slide slide = new Slide();

        DoubleArrow doubleArrow = new DoubleArrow();
        doubleArrow.Width = 300.0;
        doubleArrow.Height = 50.0;
        doubleArrow.X = doubleArrow.Width / 2;
        doubleArrow.Y = doubleArrow.Height + 200 / 2;
        slide.DrawDoubleArrow(doubleArrow);
        presentation.AppendSlide(slide);
        presentation.Save();
        */
        /* Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
         Slide slide = new Slide();

         CurvedLine curvedLine = new CurvedLine();
         curvedLine.Width = 300.0;
         curvedLine.Height = 50.0;
         curvedLine.X = curvedLine.Width / 2;
         curvedLine.Y = curvedLine.Height + 200 / 2;
         slide.DrawCurvedLine(curvedLine);
         presentation.AppendSlide(slide);
         presentation.Save();
        */
        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        Slide slide = presentation.GetSlides()[2];
        slide.Rectangles[0].Remove();
        presentation.Save();*/
        /*
        Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        Slide slide = new Slide();

        DoubleBrace doubleBrace = new DoubleBrace();
        doubleBrace.Width = 300.0;
        doubleBrace.Height = 50.0;
        doubleBrace.X = doubleBrace.Width / 2;
        doubleBrace.Y = doubleBrace.Height + 200 / 2;
        slide.DrawDoubleBrace(doubleBrace);
        presentation.AppendSlide(slide);
        presentation.Save();*/

        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        Slide slide = new Slide();

        Pentagon pentagon = new Pentagon();
        pentagon.Width = 300.0;
        pentagon.Height = 50.0;
        pentagon.X = pentagon.Width / 2;
        pentagon.Y = pentagon.Height + 200 / 2;
        slide.DrawPentagon(pentagon);
        presentation.AppendSlide(slide);
        presentation.Save();*/

        /*Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        Slide slide = new Slide();

        DoubleBracket doubleBracket = new DoubleBracket();
        doubleBracket.Width = 300.0;
        doubleBracket.Height = 50.0;
        doubleBracket.X = doubleBracket.Width / 2;
        doubleBracket.Y = doubleBracket.Height + 200 / 2;
        slide.DrawDoubleBracket(doubleBracket);
        presentation.AppendSlide(slide);
        presentation.Save();
        */

        /* Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
         Slide slide = new Slide();

         Hexagon hexagon = new Hexagon();
         hexagon.Width = 300.0;
         hexagon.Height = 300.0;
         hexagon.X = 300.0;
         hexagon.Y = 300.0;
         slide.DrawHexagon(hexagon);
         presentation.AppendSlide(slide);
         presentation.Save();*/

        //Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
        //Slide slide = new Slide();

        //Trapezoid trapezoid = new Trapezoid();
        //trapezoid.Animation = FileFormat.Slides.Common.Enumerations.AnimationType.FlyIn;
        //trapezoid.Width = 300.0;
        //trapezoid.Height = 300.0;
        //trapezoid.X = 300.0;
        //trapezoid.Y = 300.0;
        //slide.DrawTrapezoid(trapezoid);
        //presentation.AppendSlide(slide);
        //presentation.Save();

        /* Presentation presentation = Presentation.Open("D:\\AsposeSampleData\\draw.pptx");
         Slide slide = new Slide();

         Pie pie = new Pie();
         pie.Animation = FileFormat.Slides.Common.Enumerations.AnimationType.FlyIn;
         pie.Width = 300.0;
         pie.Height = 300.0;
         pie.X = 300.0;
         pie.Y = 300.0;
         slide.DrawPie(pie);
         presentation.AppendSlide(slide);
         presentation.Save();*/

        }

    }
