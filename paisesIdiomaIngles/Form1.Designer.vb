<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPergunta = New System.Windows.Forms.Label()
        Me.cbxMexico = New System.Windows.Forms.CheckBox()
        Me.cbxInglaterra = New System.Windows.Forms.CheckBox()
        Me.cbxColombia = New System.Windows.Forms.CheckBox()
        Me.cbxEstUnid = New System.Windows.Forms.CheckBox()
        Me.cbxRussia = New System.Windows.Forms.CheckBox()
        Me.cbxIrlanda = New System.Windows.Forms.CheckBox()
        Me.btnResponder = New System.Windows.Forms.Button()
        Me.lblInterrogacao = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPergunta
        '
        Me.lblPergunta.AutoSize = True
        Me.lblPergunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPergunta.Location = New System.Drawing.Point(54, 27)
        Me.lblPergunta.Name = "lblPergunta"
        Me.lblPergunta.Size = New System.Drawing.Size(159, 16)
        Me.lblPergunta.TabIndex = 0
        Me.lblPergunta.Text = "Países de idioma inglês?"
        Me.lblPergunta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbxMexico
        '
        Me.cbxMexico.AutoSize = True
        Me.cbxMexico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMexico.Location = New System.Drawing.Point(57, 51)
        Me.cbxMexico.Name = "cbxMexico"
        Me.cbxMexico.Size = New System.Drawing.Size(66, 19)
        Me.cbxMexico.TabIndex = 1
        Me.cbxMexico.Text = "México"
        Me.cbxMexico.UseVisualStyleBackColor = True
        '
        'cbxInglaterra
        '
        Me.cbxInglaterra.AutoSize = True
        Me.cbxInglaterra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxInglaterra.Location = New System.Drawing.Point(57, 175)
        Me.cbxInglaterra.Name = "cbxInglaterra"
        Me.cbxInglaterra.Size = New System.Drawing.Size(78, 19)
        Me.cbxInglaterra.TabIndex = 2
        Me.cbxInglaterra.Text = "Inglaterra"
        Me.cbxInglaterra.UseVisualStyleBackColor = True
        '
        'cbxColombia
        '
        Me.cbxColombia.AutoSize = True
        Me.cbxColombia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxColombia.Location = New System.Drawing.Point(57, 150)
        Me.cbxColombia.Name = "cbxColombia"
        Me.cbxColombia.Size = New System.Drawing.Size(79, 19)
        Me.cbxColombia.TabIndex = 3
        Me.cbxColombia.Text = "Colômbia"
        Me.cbxColombia.UseVisualStyleBackColor = True
        '
        'cbxEstUnid
        '
        Me.cbxEstUnid.AutoSize = True
        Me.cbxEstUnid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxEstUnid.Location = New System.Drawing.Point(57, 125)
        Me.cbxEstUnid.Name = "cbxEstUnid"
        Me.cbxEstUnid.Size = New System.Drawing.Size(112, 19)
        Me.cbxEstUnid.TabIndex = 4
        Me.cbxEstUnid.Text = "Estados Unidos"
        Me.cbxEstUnid.UseVisualStyleBackColor = True
        '
        'cbxRussia
        '
        Me.cbxRussia.AutoSize = True
        Me.cbxRussia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRussia.Location = New System.Drawing.Point(57, 101)
        Me.cbxRussia.Name = "cbxRussia"
        Me.cbxRussia.Size = New System.Drawing.Size(64, 19)
        Me.cbxRussia.TabIndex = 5
        Me.cbxRussia.Text = "Rússia"
        Me.cbxRussia.UseVisualStyleBackColor = True
        '
        'cbxIrlanda
        '
        Me.cbxIrlanda.AutoSize = True
        Me.cbxIrlanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIrlanda.Location = New System.Drawing.Point(57, 76)
        Me.cbxIrlanda.Name = "cbxIrlanda"
        Me.cbxIrlanda.Size = New System.Drawing.Size(64, 19)
        Me.cbxIrlanda.TabIndex = 6
        Me.cbxIrlanda.Text = "Irlanda"
        Me.cbxIrlanda.UseVisualStyleBackColor = True
        '
        'btnResponder
        '
        Me.btnResponder.Location = New System.Drawing.Point(57, 210)
        Me.btnResponder.Name = "btnResponder"
        Me.btnResponder.Size = New System.Drawing.Size(218, 31)
        Me.btnResponder.TabIndex = 7
        Me.btnResponder.Text = "Responder"
        Me.btnResponder.UseVisualStyleBackColor = True
        '
        'lblInterrogacao
        '
        Me.lblInterrogacao.AutoSize = True
        Me.lblInterrogacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterrogacao.Location = New System.Drawing.Point(243, 101)
        Me.lblInterrogacao.Name = "lblInterrogacao"
        Me.lblInterrogacao.Size = New System.Drawing.Size(21, 24)
        Me.lblInterrogacao.TabIndex = 8
        Me.lblInterrogacao.Text = "?"
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 266)
        Me.Controls.Add(Me.lblInterrogacao)
        Me.Controls.Add(Me.btnResponder)
        Me.Controls.Add(Me.cbxIrlanda)
        Me.Controls.Add(Me.cbxRussia)
        Me.Controls.Add(Me.cbxEstUnid)
        Me.Controls.Add(Me.cbxColombia)
        Me.Controls.Add(Me.cbxInglaterra)
        Me.Controls.Add(Me.cbxMexico)
        Me.Controls.Add(Me.lblPergunta)
        Me.Name = "form1"
        Me.Text = "Países - idioma Inglês"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPergunta As System.Windows.Forms.Label
    Friend WithEvents cbxMexico As System.Windows.Forms.CheckBox
    Friend WithEvents cbxInglaterra As System.Windows.Forms.CheckBox
    Friend WithEvents cbxColombia As System.Windows.Forms.CheckBox
    Friend WithEvents cbxEstUnid As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRussia As System.Windows.Forms.CheckBox
    Friend WithEvents cbxIrlanda As System.Windows.Forms.CheckBox
    Friend WithEvents btnResponder As System.Windows.Forms.Button
    Friend WithEvents lblInterrogacao As System.Windows.Forms.Label

End Class
