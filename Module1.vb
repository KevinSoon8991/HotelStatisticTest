Imports MySql.Data.MySqlClient

Module Module1
    Public cdbDir, ErrMsg, gcSQL As String
    Public gConn As MySqlConnection
    Function OpenConn(Optional ByVal ErrorMsgBox As Boolean = True) As Boolean
        cdbDir = String.Format("server=localhost; database=hotel_vb; uid=root;")
        gConn = New MySqlConnection() With {.ConnectionString = cdbDir}
        Try
            gConn.Open()
        Catch ex As Exception
            ErrMsg = "Error Message : " & ex.Message & ". Type error: " & ex.GetType.ToString & ""
            If ErrorMsgBox Then MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try

        ErrMsg = ""

        Return True
    End Function

    Function ExecDT(Optional ByVal ErrorMsgBox As Boolean = True) As DataTable
        If gcSQL = Nothing Then Return Nothing
        Using da As MySqlDataAdapter = New MySqlDataAdapter(gcSQL, gConn)
            Try
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                ErrMsg = ""
                Return dt
            Catch ex As Exception
                ErrMsg = String.Format("Error Message : {0}. Type error: {1}", ex.Message, ex.GetType)
                If ErrorMsgBox Then MessageBox.Show(ErrMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return Nothing
            Finally
                gcSQL = Nothing
            End Try
        End Using
    End Function

End Module
