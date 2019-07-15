# CMMBuilder

LK Metrology Software Developer Assignment

Name:        Sam Masamvi
Time Spent:  2hrs
.Net Target: .Net Framework 4.7.2

This application was built using Visual Studio 2017, and targets the .Net Framework 4.7.2. 


# Execution

In order to execute, simply compile the application in either debug or release mode, and select the components for the final Coordinate 
Measuring Machine (CMM) from the dropdown ComboBox controls on the left hand side. The Length, and Coefficient of Thermal Expansion (CTE) 
for the resulting CMM configuration should then be displayed below the ComboBox controls, with the appropriate image assets displayed on 
the right hand side.


# Bugs

When selecting the 3mm x 30mm CMM Tip from the tip drop down selector there is no corresponding image asset displayed, this is due to a 
miss-named asset on within the source code. An update of the name of the assosiated resource would fix the bug however due to time 
constraints this fix was not implemented.


# Improvements 

The following are improvements to I would make to the application given more time to develop it.

___UI:___

* Add lables to the ComboBox controls in order to allow the user to know what component type the are related to.
* Add aspect ratio restrictions to the image display controls in order to produce a more refined visual representation and fix resulting image deformation.
* Re-Align and improve control layout to make better use of the space on the left hand side of the application's display area.

___UX:___

* Add a control to allow a user could store the resulting CMM for future reference.
* Add a control to allow the user to import a list of CMM components.
* Add a control to allow the exporting of the applications current list of CMM components.

___Source Code:___

__Models/Interfaces/ICMMComponent.cs__

* Change "Type" propety from String to Enum. Improves component selection, extensibility, and data validity testing.


__Models/Interfaces/IDataContest.cs__

* Improve component updating via use of an enum in the Select function. 
* Use Dictionary<Type,ICMMComponent> rather than IEnumerable<String> collections in order to allow for extension of CMM Component types availble without modification.


__Models/DataContext.cs__

* Load in the list of CMMComponents and their properties via a resource file (e.g. a CSV, or Exel Doc).
* Move the BitmapImage Loading logic out of the DataContext and abstract access via an interface to decouple the provision of images from the provision of CMM Components.
* Move the CMMCTE and CMMLength calculations out of the Select method as these are not bound to what component has been just selected.


__ViewModels/Helpers/CommandRelay`1.cs__

* Remove as it is unused. The initial concept had the user pressing a button to update the data displayed on screen. However given the dynamic updating of displayed information this is no longer required.


__ViewModels/CMMBuilderPageViewModel.cs__

* Move the constructor list initialisations to thier own methods.
* All SelectedCMM...Index properties are too verbose and repetitive, all NotifyPropertyChanged calls for CMM Length, CTE, and Images 
should be moved into thier own method in order to improve maintainability, and readability.


__Views/CMMBuilderPageView.xaml__

Bindings for the components provided by the viewmodel are too repetetive, and potentially too restrictive. 
Instead Data Templates based around passing in a more complext objects ( e.g. ICMMComponent instances ), would allow for
fewer required bindgs and better abstraction.
