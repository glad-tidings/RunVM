<System.ComponentModel.RunInstaller(True)> Partial Class ProjectInstaller
    Inherits System.Configuration.Install.Installer

    'Installer overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PEVMServiceProcess = New System.ServiceProcess.ServiceProcessInstaller()
        Me.PEVMService = New System.ServiceProcess.ServiceInstaller()
        '
        'PEVMServiceProcess
        '
        Me.PEVMServiceProcess.Password = Nothing
        Me.PEVMServiceProcess.Username = Nothing
        '
        'PEVMService
        '
        Me.PEVMService.Description = "Pars Elecom Company"
        Me.PEVMService.DisplayName = "Pars Elecom VM Agent"
        Me.PEVMService.ServiceName = "PEVM"
        Me.PEVMService.StartType = System.ServiceProcess.ServiceStartMode.Automatic
        '
        'ProjectInstaller
        '
        Me.Installers.AddRange(New System.Configuration.Install.Installer() {Me.PEVMServiceProcess, Me.PEVMService})

    End Sub

    Friend WithEvents PEVMServiceProcess As ServiceProcess.ServiceProcessInstaller
    Friend WithEvents PEVMService As ServiceProcess.ServiceInstaller
End Class
