Module Module1
    Sub Main()
        ' Create library
        Dim library As New Library()

        ' Create books
        Dim book1 As New Book("The Catcher in the Rye", "J.D. Salinger")
        Dim book2 As New Book("To Kill a Mockingbird", "Harper Lee")
        Dim book3 As New Book("1984", "George Orwell")

        ' Create patrons
        Dim patron1 As New Patron("John Doe")
        Dim patron2 As New Patron("Jane Smith")

        ' Add books to the library
        library.AddBook(book1)
        library.AddBook(book2)
        library.AddBook(book3)

        ' Add patrons to the library
        library.AddPatron(patron1)
        library.AddPatron(patron2)

        ' Check out books
        library.CheckOutBook(book1, patron1)
        library.CheckOutBook(book2, patron2)

        ' Display library status
        library.DisplayLibraryStatus()
    End Sub
End Module
