Public Class Library
    Private books As New List(Of Book)
    Private patrons As New List(Of Patron)
    Private transactions As New List(Of Transaction)
    Private transactionIdCounter As Integer = 1

    Public Sub AddBook(book As Book)
        books.Add(book)
    End Sub

    Public Sub AddPatron(patron As Patron)
        patrons.Add(patron)
    End Sub

    Public Sub CheckOutBook(book As Book, patron As Patron)
        If books.Contains(book) AndAlso patrons.Contains(patron) Then
            Dim transaction As New Transaction(transactionIdCounter, book, patron)
            transactions.Add(transaction)
            transactionIdCounter += 1
        End If
    End Sub

    Public Sub DisplayLibraryStatus()
        Console.WriteLine("Library Status:")
        Console.WriteLine("Books:")
        For Each book In books
            Console.WriteLine($"- {book.Title} by {book.Author}")
        Next

        Console.WriteLine("Patrons:")
        For Each patron In patrons
            Console.WriteLine($"- {patron.Name}")
        Next

        Console.WriteLine("Transactions:")
        For Each transaction In transactions
            Console.WriteLine($"- Transaction ID: {transaction.TransactionId}, Book: {transaction.Book.Title}, Patron: {transaction.Patron.Name}")
        Next
    End Sub
End Class
