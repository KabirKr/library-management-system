Imports System.Data.SqlClient

Module DbModule
    Private ReadOnly connection As New SqlConnection("Data Source=DESKTOP-74N58MA\SQLDEVELOPER2019;Initial Catalog=LibraryManagement;Integrated Security=True")

    ' This function executes data manipulation queries 
    ' and returns the number of row affected 
    Public Function ExecuteQuery(query As String) As Integer
        Dim cmd As SqlCommand = New SqlCommand(query, connection)
        Dim val As Integer = 0

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            val = cmd.ExecuteNonQuery()
            Return val
        Catch ex As Exception
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical)
            Return val
        End Try

    End Function

    ' This function returns a dataset populated with data table
    Public Function GetDataset(query As String) As DataSet
        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter(query, connection)
        Dim dataSet As DataSet = New DataSet()

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            dataAdapter.Fill(dataSet)
            Return dataSet
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Library Management System")
            Return dataSet
        End Try

    End Function
End Module