Public Class Transaction
    Public Property TransactionId As Integer
    Public Property Book As Book
    Public Property Patron As Patron

    Public Sub New(transactionId As Integer, book As Book, patron As Patron)
        Me.TransactionId = transactionId
        Me.Book = book
        Me.Patron = patron
    End Sub
End Class
