'Copyright 2013 Esri
'Licensed under the Apache License, Version 2.0 (the "License");
'You may not use this file except in compliance with the License.
'You may obtain a copy of the License at
'http://www.apache.org/licenses/LICENSE-2.0
'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
Imports System.Windows
Imports System.Windows.Interactivity
Imports ESRI.ArcGIS.SilverlightMapApp

Namespace ESRI.ArcGIS.SilverlightMapApp.Actions
		Public Class ToggleExpandCollapseAction
			Inherits TargetedTriggerAction(Of UIElement)
				Protected Overrides Sub Invoke(ByVal parameter As Object)
						Dim panel As GlassPanel = TryCast(Me.Target, GlassPanel)
						If panel.IsOpen Then
								panel.Collapse()
						Else
								panel.Expand()
						End If
				End Sub
		End Class
End Namespace
