Imports System.Data.SqlClient

Module DbModule
    Public conn As New SqlConnection("Data Source=DESKTOP-74N58MA\SQLDEVELOPER2019;Initial Catalog=LibraryManagement;Integrated Security=True")

    Public Function InsertQuery(query As String) As Integer
        Dim cmd = New SqlCommand(query, conn)
        Dim val As Integer = 0

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            val = cmd.ExecuteNonQuery()
            Return val

        Catch ex As Exception
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical)
            Return val
        End Try
    End Function

    Public Function SearchData(query As String) As DataSet

        Dim dataAdapter As SqlDataAdapter = New SqlDataAdapter(query, conn)
        Dim dataSet As DataSet = New DataSet()

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            dataAdapter.Fill(dataSet)
            Return dataSet

        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Library Management System")
            Return dataSet
        End Try

    End Function
End Module