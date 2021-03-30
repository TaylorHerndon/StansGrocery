Option Strict On
Option Explicit On

'Taylor Herndon
'RCET0265
'Spring 2021
'Stans Grocery
'https://github.com/TaylorHerndon/StansGrocery

Public Class StansGroceryForm

    Dim temp(999) As String
    Dim food(999, 2) As String
    Sub StartupProcesses() Handles Me.Load

        temp = Split(StansGrocery.My.Resources.Grocery, vbLf, -1)

        'Assign food names, aisle number, and category
        For i = 0 To temp.Length - 1

            'Index the food name
            food(i, 0) = temp(i).Substring(6, temp(i).IndexOf(",") - 7)

            'Index the food aisle
            food(i, 1) = temp(i).Substring(temp(i).IndexOf(",") + 7, temp(i).LastIndexOf(",") - temp(i).IndexOf(",") - 8)

            'Index the food category
            food(i, 2) = temp(i).Substring(temp(i).LastIndexOf(",") + 7, temp(i).Length - temp(i).LastIndexOf(",") - 8)

        Next

        'Add each unique category to the filter combo box
        For i = 0 To temp.Length - 1

            If Not FilterComboBox.Items.Contains(food(i, 2)) And food(i, 2) <> "" Then

                FilterComboBox.Items.Add(food(i, 2))

            End If

        Next

        FilterComboBox.Items.Add("All Items") 'Add "All Items" to the filter combo box
        FilterComboBox.Sorted = True 'Sort the filter combo box by alphabetical order
        FilterComboBox.SelectedItem = "All Items" 'Set the on startup filter to all items

        DisplayListOnCategory("All Items") 'Update listed items to the all items category

    End Sub

    Sub SearchSubmit() Handles SearchButton.Click, SearchToolStripMenuItem.Click, SearchToolStripMenuItem1.Click

        Dim selectedItemNumber As Integer = 0

        FilterComboBox.SelectedItem = "All Items" 'When a search is submitted reset the filter to all items

        'If zzz is detected end the program
        If SearchTextBox.Text = "zzz" Then

            End

        End If

        'Search the food array for the searched item
        For i = 0 To temp.Length - 1

            If food(i, 0) = SearchTextBox.Text And food(i, 0) <> "" Then

                selectedItemNumber = i 'If a match is found set the selected item number to the current index
                Exit For 'Exit the for loop

            End If

            If i = temp.Length - 1 Then

                selectedItemNumber = -1 'If no match was found then set the selected item to -1

            End If

        Next

        If selectedItemNumber = -1 Then

            DisplayLabel.Text = "Item could not be found." 'If item could not be found inform the user

        Else

            'If a match was found then fill out the item name, aisle name, and category to the display label
            DisplayLabel.Text = food(selectedItemNumber, 0) &
                                " can be found in aisle " & food(selectedItemNumber, 1) &
                                " with the " & food(selectedItemNumber, 2)

        End If

    End Sub

    Sub DisplayListOnCategory(category As String)

        DisplayListBox.Items.Clear() 'Clear the item list

        'All items was selected then fill out the item list with all items
        If category = "All Items" Then

            For i = 0 To temp.Length - 1

                If food(i, 0) <> "" Then

                    DisplayListBox.Items.Add(food(i, 0))

                End If

            Next

            DisplayListBox.Sorted = True 'Sort the item list by alphabetical order
            Exit Sub 'Exit the sub

        End If



        For i = 0 To temp.Length

            'Add all of the items with the selected category to the item list box
            If food(i, 0) <> "" And food(i, 2) = category Then

                DisplayListBox.Items.Add(food(i, 0))

            End If

            DisplayListBox.Sorted = True 'Sort the item list by alphabetical order

        Next

    End Sub

    Sub UpdateDisplayBoxFromListBox() Handles DisplayListBox.Click

        Dim selectedItemNumber As Integer = 0

        'Search the food array for the selected item
        For i = 0 To temp.Length - 1

            If food(i, 0) Is DisplayListBox.SelectedItem Then

                selectedItemNumber = i 'Once the selected item has been found set the item number to the current index
                Exit For 'Exit the for loop

            End If

        Next

        'Fill out the item name, aisle name, and category to the display label
        DisplayLabel.Text = food(selectedItemNumber, 0) &
                            " can be found in aisle " & food(selectedItemNumber, 1) &
                            " with the " & food(selectedItemNumber, 2)

    End Sub

    Sub UpdateDisplayListBox() Handles FilterComboBox.SelectedIndexChanged

        DisplayListOnCategory(FilterComboBox.SelectedItem.ToString) 'Update the item list box to only display the selected category

    End Sub

    Sub Help() Handles AboutTopMenuItem.Click

        'Display a message box with information about the search engine
        MsgBox("Welcome to Stan's Grocery search engine!" & vbNewLine & vbNewLine &
               "To search for a specific item type your item name into the text box labeled 'Look Up Item'." & vbNewLine & vbNewLine &
               "You can also select an item by clicking the item in the item list on the right." & vbNewLine & vbNewLine &
               "To trim down your item selection choose a category with the 'Item Filter' box." & vbNewLine & vbNewLine &
               "Your item, aisle, and similar items will be displayed under the 'Item Filter' box.")

    End Sub

    Sub ExitProgram() Handles ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click

        End

    End Sub

End Class