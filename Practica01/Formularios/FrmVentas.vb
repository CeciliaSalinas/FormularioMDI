Public Class FrmVentas
    'variable compartida , me dice si hay una instancia o no
    Public Shared primerInstancia As FrmVentas
    Public Function getInstancia() As FrmVentas 'devuelve un objeto de tipo frmVentas

        If primerInstancia Is Nothing Then
            primerInstancia = New FrmVentas
            Return New FrmVentas
        Else
            Return primerInstancia
        End If

    End Function

    Public Sub ingresarDatos(productos As String) 'parametro de tip string
        TxtProductos.Text = productos
    End Sub
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'este botón busca del formulario la listaDeproductos para seleccionar
    'SHOWDIALOG,para que no podamos acceder a los formularios restantes inferiores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listaP As New FrmListaProductos
        listaP.ShowDialog()

    End Sub

    Private Sub FrmVentas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        primerInstancia = Nothing
    End Sub
End Class