# CMMBuilder

LK Metrology Software Developer Assignment

Name:        Sam Masamvi
Time Spent:  2hrs
.Net Target: .Net Framework 4.7.2

This application was built using Visual Studio 2017, and targets the .Net Framework 4.7.2. 

#Execution

In order to execute, simply compile the application in either debug or release mode, and select the components for the final Coordinate 
Measuring Machine (CMM) from the dropdown ComboBox controls on the left hand side. The Length, and Coefficient of Thermal Expansion (CTE) 
for the resulting CMM configuration should then be displayed below the ComboBox controls, with the appropriate image assets displayed on 
the right hand side.

#Bugs

When selecting the 3mm x 30mm CMM Tip from the tip drop down selector there is no corresponding image asset displayed, this is due to a 
miss-named asset on within the source code. An update of the name of the assosiated resource would fix the bug however due to time 
constraints this fix was not implemented.

#Improvements 

The following are improvements to I would make to the application given more time to develop it.

UI:

Add labeles to the ComboBox controls in order to allow the user to know what component type the are related to.
Add aspect ratio restrictions to the image display controls in order to produce a more refined visual representation and fix resulting 
image deformation.
Re-Align and improve control layout to make better use of the space on the left hand side of the application's display area.

UX:

Add a control to allow a user could store the resulting CMM for future reference.
Add a control to allow the user to import a list of CMM components.
Add a control to allow the exporting of the applications current list of CMM components.

Source Code:

Models/Interfaces/ICMMComponent.cs

Rather than using a string to denote "type" I would have preffered to make use of an enumeration, to allow for better componentn 
selection and better data validity testing.


Modles/Interfaces/IDataContest.cs

Improved component updateting via use of an enum in the Select function. 
Using a Dictionary<Type,ICMMComponent> rather than individual IEnumerable<String> collections in order to allow for extension of 
CMM Component types availble in the future without having to update data context logic.


Modesl/DataContext.cs

Loading in the list of CMMComponents and their properties via a resource file (e.g. a CSV, or Exel Doc) rather than hard-coded Lists.
Moved the BitmapImage Loading logic out of the DataContext file and abstracting it via it's own interface to decouple the provision 
of images from the provision of CMM Components.
Moved the CMMCTE and CMMLength calculations out of the Select method as these are not bound to what compnent has been just selected 
and thus should not be in this method.


ViewModels/Helpers/CommandRelay`1.cs

I would remove this class as it is unused. My initial idea had the user pressing a button to update the data displayed on screen, 
however given that I opted instead for dynamic updating of displayed information this is no longer required.


ViewModels/CMMBuilderPageViewModel.cs

Move the constructor list initialisations to thier own methods.
All SelectedCMM...Index properties are too verbose and repetitive, I would have moved all the NotifyPropertyChanged calls for CMM 
Length, CTE, and Images into thier own method in order to improve maintainability, and readability.


Views/CMMBuilderPageView.xaml

Here the bindings for the components provided by the viewmodel are too repetetive, and potentially too restrictive as to how a 
supporting view model would have to be implemented. I would have preferd to create approprite Data Templates that are based around 
passing in a more complext object ( like an ICMMComponent instance ), which would allow for fewer required bindgs and more abstraction.
