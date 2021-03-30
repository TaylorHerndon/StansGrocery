<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.LookUpLabel = New System.Windows.Forms.Label()
        Me.SelectLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LeftGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStripA = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopMenuStrip.SuspendLayout()
        Me.LeftGroupBox.SuspendLayout()
        Me.ContextMenuStripA.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(938, 33)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileTopMenuItem.Text = "&File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpTopMenuItem.Text = "&Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutTopMenuItem.Text = "&About"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SearchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.SearchTextBox.Location = New System.Drawing.Point(135, 63)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(614, 26)
        Me.SearchTextBox.TabIndex = 1
        Me.ToolTipMain.SetToolTip(Me.SearchTextBox, "Type your desired item here")
        '
        'FilterComboBox
        '
        Me.FilterComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.FilterComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(135, 103)
        Me.FilterComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(325, 28)
        Me.FilterComboBox.TabIndex = 2
        Me.ToolTipMain.SetToolTip(Me.FilterComboBox, "Select a category to filter your search")
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(471, 103)
        Me.DisplayListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(434, 384)
        Me.DisplayListBox.TabIndex = 3
        Me.ToolTipMain.SetToolTip(Me.DisplayListBox, "Choose from a selection of items")
        '
        'LookUpLabel
        '
        Me.LookUpLabel.AutoSize = True
        Me.LookUpLabel.Location = New System.Drawing.Point(20, 63)
        Me.LookUpLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LookUpLabel.Name = "LookUpLabel"
        Me.LookUpLabel.Size = New System.Drawing.Size(105, 20)
        Me.LookUpLabel.TabIndex = 4
        Me.LookUpLabel.Text = "Look Up Item"
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Location = New System.Drawing.Point(45, 106)
        Me.SelectLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(80, 20)
        Me.SelectLabel.TabIndex = 5
        Me.SelectLabel.Text = "Item Filter"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(760, 63)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(147, 31)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = "&Search"
        Me.ToolTipMain.SetToolTip(Me.SearchButton, "Click or press enter to search for your item")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LeftGroupBox
        '
        Me.LeftGroupBox.Controls.Add(Me.DisplayLabel)
        Me.LeftGroupBox.Location = New System.Drawing.Point(135, 144)
        Me.LeftGroupBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LeftGroupBox.Name = "LeftGroupBox"
        Me.LeftGroupBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LeftGroupBox.Size = New System.Drawing.Size(327, 345)
        Me.LeftGroupBox.TabIndex = 7
        Me.LeftGroupBox.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(4, 25)
        Me.DisplayLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(314, 315)
        Me.DisplayLabel.TabIndex = 0
        '
        'ContextMenuStripA
        '
        Me.ContextMenuStripA.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripA.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStripA.Name = "ContextMenuStrip"
        Me.ContextMenuStripA.Size = New System.Drawing.Size(137, 68)
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(136, 32)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(136, 32)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 514)
        Me.ContextMenuStrip = Me.ContextMenuStripA
        Me.Controls.Add(Me.LeftGroupBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.LookUpLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "StansGroceryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Stan's Grocery"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.LeftGroupBox.ResumeLayout(False)
        Me.ContextMenuStripA.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents LookUpLabel As Label
    Friend WithEvents SelectLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents LeftGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripA As ContextMenuStrip
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolTipMain As ToolTip
End Class
