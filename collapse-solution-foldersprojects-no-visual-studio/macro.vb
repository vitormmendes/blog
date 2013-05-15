Imports System
Imports EnvDTE
Imports EnvDTE80
Imports System.Diagnostics

Public Module CollapseAll
    Sub CollapseAll()
        Dim solutionExplorer As UIHierarchy
        solutionExplorer = DTE.Windows.Item(Constants.vsext_wk_SProjectWindow).Object()

        If (solutionExplorer.UIHierarchyItems.Count = 0) Then
            Return
        End If
        Dim rootNode As UIHierarchyItem = solutionExplorer.UIHierarchyItems.Item(1)
        rootNode.DTE.SuppressUI = True
        Collapse(rootNode, solutionExplorer)
        rootNode.Select(vsUISelectionType.vsUISelectionTypeSelect)
        rootNode.DTE.SuppressUI = False
    End Sub

    Sub CollapseSelected()
        Dim solutionExplorer As UIHierarchy
        solutionExplorer = DTE.Windows.Item(Constants.vsext_wk_SProjectWindow).Object()
        If (solutionExplorer.UIHierarchyItems.Count = 0) Then
            Return
        End If
        Dim selected As Array = solutionExplorer.SelectedItems
        If (selected.Length = 0) Then Return
        Dim rootNode As UIHierarchyItem = selected(0)
        rootNode.DTE.SuppressUI = True
        Collapse(rootNode, solutionExplorer)
        rootNode.Select(vsUISelectionType.vsUISelectionTypeSelect)
        rootNode.DTE.SuppressUI = False
    End Sub

    Private Sub Collapse(ByVal item As UIHierarchyItem, ByRef solutionExplorer As UIHierarchy)
        For Each innerItem As UIHierarchyItem In item.UIHierarchyItems
            If innerItem.UIHierarchyItems.Count > 0 Then
                Collapse(innerItem, solutionExplorer)
                If innerItem.UIHierarchyItems.Expanded Then
                    innerItem.UIHierarchyItems.Expanded = False
                    If innerItem.UIHierarchyItems.Expanded = True Then
                        ' Bug no VS 2005
                        innerItem.Select(vsUISelectionType.vsUISelectionTypeSelect)
                        solutionExplorer.DoDefaultAction()
                    End If
                End If
            End If
        Next
    End Sub
End Module