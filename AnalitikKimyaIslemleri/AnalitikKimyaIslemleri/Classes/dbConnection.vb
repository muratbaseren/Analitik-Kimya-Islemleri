#Region "Imports"
Imports System
Imports System.data
Imports System.data.oledb
#End Region

Public Class dbConnection
#Region "LocalVariables"
    Private MyConn_ As OleDbConnection
    Private MyCmd_ As OleDbCommand
    Private ConnStr_ As String
#End Region

#Region "Properties"
    Public Property MyConn() As OleDbConnection
        Get
            Return Me.MyConn_
        End Get
        Set(ByVal value As OleDbConnection)
            Me.MyConn_ = value
        End Set
    End Property
    Public Property MyCmd() As OleDbCommand
        Get
            Return Me.MyCmd_
        End Get
        Set(ByVal value As OleDbCommand)
            Me.MyCmd_ = value
        End Set
    End Property
    Public Property ConnStr() As String
        Get
            Return Me.ConnStr_
        End Get
        Set(ByVal value As String)
            Me.ConnStr_ = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New(ByVal DatabaseIsmi As String)
        Me.ConnStr_ = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\" & DatabaseIsmi & ";"
        Me.MyConn_ = New OleDbConnection(Me.ConnStr_)
        Me.MyCmd_ = New OleDbCommand
        Me.MyCmd_.Connection = Me.MyConn_
        Me.MyCmd_.CommandType = CommandType.Text
    End Sub

    Public Sub New(ByVal ConnectionString As String, ByVal IsYourConnection As Boolean)
        Me.ConnStr_ = ConnectionString
        Me.MyConn_ = New OleDbConnection(Me.ConnStr_)
        Me.MyCmd_ = New OleDbCommand
        Me.MyCmd_.Connection = Me.MyConn_
        Me.MyCmd_.CommandType = CommandType.Text
    End Sub
#End Region

#Region "Methods"
    Public Sub CreateTable(ByVal IsTable1 As Boolean, ByVal TableName As String)
        If IsTable1 = True Then
            Me.MyCmd_.CommandText = "CREATE TABLE " & TableName & _
                " ( " & _
                    "ID int PRIMARY KEY unique, " & _
                    "TitrantHacmi char(15), " & _
                    "ToplamHacim char(15), " & _
                    "Dersimi char(15), " & _
                    "Ph char(15)  " & _
                ") "
        Else
            Me.MyCmd_.CommandText = "CREATE TABLE " & TableName & _
                " ( " & _
                    "ID int PRIMARY KEY unique, " & _
                    "TitrantIsmi char(30), " & _
                    "TitrantDerisimi char(15), " & _
                    "TitrantHacmi char(15), " & _
                    "TitrantTuru char(10), " & _
                    "TitreEdilenIsmi char(30), " & _
                    "TitreEdilenDerisimi char(15), " & _
                    "TitreEdilenHacmi char(15), " & _
                    "TitreEdilenTuru char(10), " & _
                    "TesirDegeri char(15), " & _
                    "HacimArtisi char(15), " & _
                    "RaporBasligi char(60), " & _
                    "DipNot char(190), " & _
                    "Imza char(60) " & _
                ") "
        End If

        Try
            Me.MyConn.Open()
            Me.MyCmd.ExecuteNonQuery()

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message.ToString, "Database Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Genel Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Finally
            Me.MyConn.Close()
        End Try
    End Sub

    Public Sub DropTable(ByVal TableName As String)
        Me.MyCmd_.CommandText = "DROP TABLE " & TableName

        Try
            Me.MyConn.Open()
            Me.MyCmd.ExecuteNonQuery()

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message.ToString, "Database Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Genel Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Finally
            Me.MyConn.Close()
        End Try
    End Sub

    Public Sub InsertTable1(ByVal TableName As String, ByVal DT As DataTable)
        Try
            Me.MyConn.Open()

            For i As Integer = 0 To DT.Rows.Count - 1

                Dim Drow As DataRow = DT.Rows(i)

                Me.MyCmd_.CommandText = "INSERT INTO " & TableName & " ( ID, TitrantHacmi, ToplamHacim, Dersimi, Ph ) VALUES ( " & i & ", '" & CType(Drow(0).ToString, Single).ToString & "', '" & CType(Drow(1).ToString, Single).ToString & "', '" & CType(Drow(2).ToString, Single).ToString & "', '" & CType(Drow(3).ToString, Single).ToString & "')"

                'Me.MyCmd_.Parameters.AddWithValue("@ID", i)
                'Me.MyCmd_.Parameters.AddWithValue("@TitrantHacmi", )
                'Me.MyCmd_.Parameters.AddWithValue("@ToplamHacim", )
                'Me.MyCmd_.Parameters.AddWithValue("@Dersimi", )
                'Me.MyCmd_.Parameters.AddWithValue("@Ph", )

                Me.MyCmd.ExecuteNonQuery()
            Next

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message.ToString, "Database Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Genel Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Finally
            Me.MyConn.Close()
        End Try
    End Sub

    Public Sub InsertTable2(ByVal TableName As String, ByVal Drow As DataRow)

        Me.MyCmd_.CommandText = "INSERT INTO " & TableName & " ( ID, TitrantIsmi, TitrantDerisimi, TitrantHacmi, TitrantTuru, TitreEdilenIsmi, TitreEdilenDerisimi, TitreEdilenHacmi, TitreEdilenTuru, TesirDegeri, HacimArtisi, RaporBasligi, DipNot, Imza ) VALUES (" & 1 & " , '" & Drow(0).ToString & "' , '" & Drow(1).ToString & "' , '" & Drow(2).ToString & "' , '" & Drow(3).ToString & "' , '" & Drow(4).ToString & "' , '" & Drow(5).ToString & "' , '" & Drow(6).ToString & "' , '" & Drow(7).ToString & "' , '" & Drow(8).ToString & "' , '" & Drow(9).ToString & "' , '" & Drow(10).ToString & "' , '" & Drow(11).ToString & "' , '" & Drow(12).ToString & "')"
        Try
            'Sadece 1 satýrlýk veri gelecek..
            'Me.MyCmd_.Parameters.AddWithValue("@ID", 1)
            'Me.MyCmd_.Parameters.AddWithValue("@TitrantIsmi", )
            'Me.MyCmd_.Parameters.AddWithValue("@TitrantDerisimi", )
            'Me.MyCmd_.Parameters.AddWithValue("@TitrantHacmi", )
            'Me.MyCmd_.Parameters.AddWithValue("@TitrantTuru", )
            'Me.MyCmd_.Parameters.AddWithValue("@TitreEdilenIsmi", )
            'Me.MyCmd_.Parameters.AddWithValue("@TitreEdilenDerisimi", )
            'Me.MyCmd_.Parameters.AddWithValue("@TitreEdilenHacmi", )
            'Me.MyCmd_.Parameters.AddWithValue("@TitreEdilenTuru", )
            'Me.MyCmd_.Parameters.AddWithValue("@TesirDegeri", )
            'Me.MyCmd_.Parameters.AddWithValue("@HacimArtisi", )
            'Me.MyCmd_.Parameters.AddWithValue("@RaporBasligi", )
            'Me.MyCmd_.Parameters.AddWithValue("@DipNot", )
            'Me.MyCmd_.Parameters.AddWithValue("@Imza", )

            Me.MyConn.Open()
            Me.MyCmd.ExecuteNonQuery()

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message.ToString, "Database Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Genel Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Finally
            Me.MyConn.Close()
        End Try
    End Sub

    Public Sub DeleteTables(ByVal Table1Name As String, ByVal Table2Name As String)
        Try
            Dim TabloIsmi As String = ""

            Me.MyConn.Open()

            For i As Integer = 1 To 2
                If i = 1 Then
                    Me.MyCmd_.CommandText = "DELETE FROM " & Table1Name
                Else
                    Me.MyCmd_.CommandText = "DELETE FROM " & Table2Name
                End If

                Me.MyCmd.ExecuteNonQuery()
            Next

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message.ToString, "Database Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Genel Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Finally
            Me.MyConn.Close()
        End Try
    End Sub

    Public Function SelectTable(ByVal TabloIsmi As String) As DataTable
        Try
            SelectTable = New DataTable
            Me.MyCmd_.CommandText = "SELECT * FROM " & TabloIsmi

            Dim DA As OleDbDataAdapter = New OleDbDataAdapter(Me.MyCmd.CommandText.ToString, Me.MyConn)

            DA.Fill(SelectTable)

        Catch exOle As OleDbException
            MessageBox.Show(exOle.Message.ToString, "Database Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Genel Hata!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try

        Return SelectTable
    End Function
#End Region
End Class
