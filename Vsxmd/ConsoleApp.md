##### ConsoleApp

# <a name='assembly'></a>Assembly: ConsoleApp

!include(./ConsoleApp.md)

##### WhitelistViewModel
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel'></a>WhitelistViewModel

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.Mvvm.ViewModels

### Summary

View Model for managing Regular Expression patterns
 used to whitelist tables from purging.


### Property

| Name | Description |
|---|---|
|[ServiceProvider](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-ServiceProvider)|instance from|
|[Logger](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Logger)|instance from|
|[IgnoredTableRepository](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-IgnoredTableRepository)|NetForum ORM-based Repository for the|
|[SearchViewModel](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-SearchViewModel)|View Model that provides several common functions such as holding the|
|[StatusBarViewModel](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-StatusBarViewModel)|Local copy of the|
|[Regex](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Regex)|The currently selected 's|
|[Whitelist](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Whitelist)|containing the|
|[Matches](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Matches)|Tables matching the current pattern expressed in the `Regex` property|
|[TextChangedCommand](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-TextChangedCommand)|instance used by the|
|[MatchTablesCommand](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-MatchTablesCommand)|instance used by the|
|[AddToWhitelistCommand](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-AddToWhitelistCommand)|instance used by the|
|[DeleteFromWhitelistCommand](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-DeleteFromWhitelistCommand)|instance used by the|
|[SelectedTable](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-SelectedTable)|The currently selected|


### Method

| Name | Description |
|---|---|
|[#ctor(serviceProvider,logger,ignoredTableRepository,searchViewModel,statusBarViewModel)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel--ctor-System-IServiceProvider,Microsoft-Extensions-Logging-ILogger-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-DashboardViewModel-,AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Repositories-IgnoredTableRepository,AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-SearchViewModel,AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-StatusBarViewModel-)|Constructor that provides resources created by Dependency Injection|
|[Initialize()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Initialize)|Called by  Window|
|[Match()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Match)|Method to apply Regular Expression matching to the list of|
|[ReadWhitelist()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-ReadWhitelist)|Method used to populate the `Whitelist` property from the|
|[SaveRegex()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-SaveRegex)|Saves the current Regular Expression to|
|[Dispose()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Dispose)|implementation|
|[DeleteRegex(regex)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-DeleteRegex-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Entities-IgnoredTable-)|Removes the selected|


### Remarks

### Extends
 * [ObservableBase](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ObservableBase)
 
 ### Implements
 *

 ### Notes
 __Constructed only via Dependency Injection.__

##### Program
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-Program'></a>Program

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp


### Property

| Name | Description |
|---|---|
|[Startup](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Program-Startup)|The instance of  used to build the|


### Method

| Name | Description |
|---|---|
|[Main(args)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Program-Main-System-String---)|Application entry point|


##### CanBeNullAttribute
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-CanBeNullAttribute'></a>CanBeNullAttribute

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.Properties

### Summary

Indicates that the value of the marked element could be `null` sometimes,
so checking for `null` is required before its usage.



### Example

```csharp
[CanBeNull] object Test() =&gt; null;
void UseTest() {
  var p = Test();
  var s = p.ToString(); // Warning: Possible 'System.NullReferenceException'
}
```

##### ImplicitUseKindFlags
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags'></a>ImplicitUseKindFlags

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.Properties

### Summary

Specify the details of implicitly used symbol when it is marked
with [](#!-MeansImplicitUseAttribute) or [](#!-UsedImplicitlyAttribute).


### Constants

| Name | Description |
|---|---|
|[Access](#F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags-Access)|Only entity marked with attribute considered used|
|[Assign](#F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags-Assign)|Indicates implicit assignment to a member|
|[InstantiatedWithFixedConstructorSignature](#F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags-InstantiatedWithFixedConstructorSignature)|Indicates implicit instantiation of a type with fixed constructor signature|
|[InstantiatedNoFixedConstructorSignature](#F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags-InstantiatedNoFixedConstructorSignature)|Indicates implicit instantiation of a type|


##### ImplicitUseTargetFlags
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseTargetFlags'></a>ImplicitUseTargetFlags

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.Properties

### Summary

Specify what is considered to be used implicitly when marked
with [](#!-MeansImplicitUseAttribute) or [](#!-UsedImplicitlyAttribute).


### Constants

| Name | Description |
|---|---|
|[Members](#F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseTargetFlags-Members)|Members of entity marked with attribute are considered used|
|[WithMembers](#F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseTargetFlags-WithMembers)|Entity marked with attribute and all its members considered used|


##### NotifyPropertyChangedInvocatorAttribute
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-NotifyPropertyChangedInvocatorAttribute'></a>NotifyPropertyChangedInvocatorAttribute

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.Properties

### Summary

Indicates that the method is contained in a type that implements
 `System.ComponentModel.INotifyPropertyChanged` interface and this method
 is used to notify that some property value changed.



### Example

```csharp
 public class Foo : INotifyPropertyChanged {
   public event PropertyChangedEventHandler PropertyChanged;
 
   [NotifyPropertyChangedInvocator]
   protected virtual void NotifyChanged(string propertyName) { ... }
   string _name;
 
   public string Name {
     get { return _name; }
     set { _name = value; NotifyChanged("LastName"); /* Warning */ }
   }
 }
 
```

Examples of generated notifications:

### Remarks

The method should be non-static and conform to one of the supported signatures:

##### NotNullAttribute
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-NotNullAttribute'></a>NotNullAttribute

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.Properties

### Summary

Indicates that the value of the marked element can never be `null`.



### Example

```csharp
[NotNull] object Foo() {
  return null; // Warning: Possible 'null' assignment
}
```

##### Startup
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup'></a>Startup

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp

### Summary

The \`Startup\` class interprets the command line
 to determine the mode of the application
 (Console, Windows Service, GUI)
 and set up the application [IHost](#T-Microsoft-Extensions-Hosting-IHost) accordingly.


### Property

| Name | Description |
|---|---|
|[StatusBarViewModel](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-StatusBarViewModel)|Shared instance of  for|
|[EntryLocation](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-EntryLocation)|The path where this AppDomain was initialized|
|[Host](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-Host)|instance built from command line|
|[Services](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-Services)|Configured Service Provider for the global context|
|[Logger](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-Logger)|Configured Logger for the global context|


### Method

| Name | Description |
|---|---|
|[BuildHost(args)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-BuildHost-System-String---)|Entry point to obtaining an instance of|
|[GetConnection(provider)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-GetConnection-System-IServiceProvider-)|Creates instances of NfDbConnection|
|[Conn_InfoMessage(sender,e)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-Conn_InfoMessage-System-Object,Avectra-netForum-Common-NfDbInfoMessageEventArgs-)|Handles `NfDbConnection`'s async information event|


### Remarks

### Dependency Injection
 [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/)
 is utilized to provide DI to the application.  Depending on the mode the application
 is running determines what objects are assigned to be constructed by DI.

 ### Configuration
 Configuration is provided by both the classic \`App.config\` file to support the
 NetForum ORM and the newer
 [Microsoft.Extensions.Configuration](https://www.nuget.org/packages/Microsoft.Extensions.Configuration/) based
 \`appsettings.json\` paradigm for all other configuration.

 ### \`NfDbConnection\` Factory
 The \`Startup\` class has a method that creates NetForum Connections and appropriately
 populates their connection string.

 ### Hosting
 [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) is
 used to coordinate the lifecycle of the DI, Logging and Configuration via a standard methodology
 implemented by the object.  There is a \`ConsoleHost\` which is registered with
 DI for when the application is not running as a GUI, and a \`WpfHost\` for when the application is running
 as a GUI.

##### App
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App'></a>App

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.WPF

### Summary

Application definition for NetForum Purge Service
GUI Windows.


### Property

| Name | Description |
|---|---|
|[Services](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App-Services)|instance from|


### Method

| Name | Description |
|---|---|
|[#ctor(services)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App--ctor-System-IServiceProvider-)|Created by the|
|[Cleanup()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App-Cleanup)|Called from [Launcher](#launcher) to stop the main window|
|[Main()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App-Main)|Application Entry Point|


##### TableTemplateSelector
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Converters-TableTemplateSelector'></a>TableTemplateSelector

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.WPF.Converters

### Summary




### Method

| Name | Description |
|---|---|
|[SelectTemplate(item,container)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Converters-TableTemplateSelector-SelectTemplate-System-Object,System-Windows-DependencyObject-)||


##### Dashboard
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Dashboard'></a>Dashboard

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.WPF.Forms

### Summary

Interaction logic for Dashboard.xaml


### Method

| Name | Description |
|---|---|
|[InitializeComponent()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Dashboard-InitializeComponent)|InitializeComponent|


##### MainWindow
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-MainWindow'></a>MainWindow

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.WPF.Forms

### Summary

Interaction logic for MainWindow.xaml


### Method

| Name | Description |
|---|---|
|[InitializeComponent()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-MainWindow-InitializeComponent)|InitializeComponent|


##### Schedule
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Schedule'></a>Schedule

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.WPF.Forms

### Summary

Schedule


### Method

| Name | Description |
|---|---|
|[InitializeComponent()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Schedule-InitializeComponent)|InitializeComponent|


##### Whitelist
## Type: <a name='T-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist'></a>Whitelist

### Namespace

AAP.Applications.NetforumDataPurge.ConsoleApp.WPF.Forms

### Summary

Provides user interface for managing the [Whitelisting](#whitelisting) patterns.


### Property

| Name | Description |
|---|---|
|[ServiceProvider](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-ServiceProvider)|instance from|
|[StatusBarViewModel](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-StatusBarViewModel)|Local copy of the|
|[ViewModel](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-ViewModel)|Instance of  that holds the|


### Method

| Name | Description |
|---|---|
|[#ctor(serviceProvider,viewModel)](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist--ctor-System-IServiceProvider,AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-)|Public constructor for this Window|
|[InitializeComponent()](#M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-InitializeComponent)|InitializeComponent|


#### Access
### Constants: <a name='F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags-Access'></a>Access

### Summary

Only entity marked with attribute considered used.



#### Assign
### Constants: <a name='F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags-Assign'></a>Assign

### Summary

Indicates implicit assignment to a member.



#### InstantiatedWithFixedConstructorSignature
### Constants: <a name='F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags-InstantiatedWithFixedConstructorSignature'></a>InstantiatedWithFixedConstructorSignature

### Summary

Indicates implicit instantiation of a type with fixed constructor signature.
That means any unused constructor parameters won't be reported as such.



#### InstantiatedNoFixedConstructorSignature
### Constants: <a name='F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseKindFlags-InstantiatedNoFixedConstructorSignature'></a>InstantiatedNoFixedConstructorSignature

### Summary

Indicates implicit instantiation of a type.



#### Members
### Constants: <a name='F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseTargetFlags-Members'></a>Members

### Summary

Members of entity marked with attribute are considered used.



#### WithMembers
### Constants: <a name='F-AAP-Applications-NetforumDataPurge-ConsoleApp-Properties-ImplicitUseTargetFlags-WithMembers'></a>WithMembers

### Summary

Entity marked with attribute and all its members considered used.



#### ServiceProvider
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-ServiceProvider'></a>ServiceProvider

### Summary

[IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') instance from
[Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/) package.



### Remarks

Dependency Injection is used throughout the application except where IDisposable instances must be immediately
disposed.

#### Logger
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Logger'></a>Logger

### Summary

[ILogger](#T-Microsoft-Extensions-Logging-ILogger) instance from
[Microsoft.Extensions.Logging](https://www.nuget.org/packages/Microsoft.Extensions.Logging/) package.



### Remarks

__Created by DI only.__

#### IgnoredTableRepository
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-IgnoredTableRepository'></a>IgnoredTableRepository

### Summary

NetForum ORM-based Repository for the
[IgnoredTable](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Entities-IgnoredTable) Entity.



### Remarks

__Created by DI only.__

#### SearchViewModel
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-SearchViewModel'></a>SearchViewModel

### Summary

View Model that provides several common functions such as holding the
that holds
the primary key for each NetForum table.



#### StatusBarViewModel
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-StatusBarViewModel'></a>StatusBarViewModel

### Summary

Local copy of the [StatusBarViewModel](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-StatusBarViewModel).  Should
be same instance as that held by the [Whitelist](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Whitelist)
Window.



#### Regex
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Regex'></a>Regex

### Summary

The currently selected [IgnoredTable](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Entities-IgnoredTable)'s
\`Regex\` property value.



### Remarks

Updates in real-time when user types in the pattern text box.

#### Whitelist
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Whitelist'></a>Whitelist

### Summary

containing the
[IgnoredTable](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Entities-IgnoredTable) Entities loaded and persisted in the
\`P05-Whitelist Table\`.



#### Matches
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Matches'></a>Matches

### Summary

Tables matching the current pattern expressed in the \`Regex\` property.



#### TextChangedCommand
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-TextChangedCommand'></a>TextChangedCommand

### Summary

[TextChangedCommand](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-TextChangedCommand) instance used by the [Whitelist](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Whitelist)
window.  Used to keep the \`Regex\` property updated in real-time.



#### MatchTablesCommand
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-MatchTablesCommand'></a>MatchTablesCommand

### Summary

[MatchTablesCommand](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-MatchTablesCommand) instance used by the [Whitelist](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Whitelist)
window.  Used to apply the filter to the NetForum tables.



#### AddToWhitelistCommand
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-AddToWhitelistCommand'></a>AddToWhitelistCommand

### Summary

[AddToWhitelistCommand](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-AddToWhitelistCommand) instance used by the [Whitelist](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Whitelist)
window.  Used to add or update the \`P05-Whitelist Table\`.



#### DeleteFromWhitelistCommand
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-DeleteFromWhitelistCommand'></a>DeleteFromWhitelistCommand

### Summary

[DeleteFromWhitelistCommand](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-DeleteFromWhitelistCommand) instance used by the [Whitelist](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Whitelist)
window.  Used to delete from the \`P05-Whitelist Table\`.



#### SelectedTable
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-SelectedTable'></a>SelectedTable

### Summary

The currently selected [IgnoredTable](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Entities-IgnoredTable)
by the user.



### Remarks

Applies the selected Regular Expression to the \`Regex\` property
and performs a \`Match\`.

#### Startup
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Program-Startup'></a>Startup

### Summary

The instance of [Startup](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Program-Startup) used to build the
application in this AppDomain.



#### StatusBarViewModel
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-StatusBarViewModel'></a>StatusBarViewModel

### Summary

Shared instance of for
code that is not attached to a GUI Window, but may want to update a GUI window
if there is one available.



#### EntryLocation
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-EntryLocation'></a>EntryLocation

### Summary

The path where this AppDomain was initialized.



#### Host
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-Host'></a>Host

### Summary

instance built from command line
options.



#### Services
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-Services'></a>Services

### Summary

Configured Service Provider for the global context.  **Should not be referenced
from the Launcher's AppDomain!**



#### Logger
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-Logger'></a>Logger

### Summary

Configured Logger for the global context.  **Should not be referenced
from the Launcher's AppDomain!**



#### Services
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App-Services'></a>Services

### Summary

[IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') instance from
[Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/) package.



### Remarks

Dependency Injection is used throughout the application except where IDisposable instances must be immediately
disposed.

#### ServiceProvider
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-ServiceProvider'></a>ServiceProvider

### Summary

[IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') instance from
[Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/) package.



### Remarks

Dependency Injection is used throughout the application except where IDisposable instances must be immediately
disposed.

#### StatusBarViewModel
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-StatusBarViewModel'></a>StatusBarViewModel

### Summary

Local copy of the [StatusBarViewModel](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-StatusBarViewModel).  Used to
drive the status bar of this Window.



#### ViewModel
### Property: <a name='P-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-ViewModel'></a>ViewModel

### Summary

Instance of [WhitelistViewModel](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel) that holds the
data and logic for this Window.



#### #ctor
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel--ctor-System-IServiceProvider,Microsoft-Extensions-Logging-ILogger-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-DashboardViewModel-,AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Repositories-IgnoredTableRepository,AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-SearchViewModel,AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-StatusBarViewModel-'></a>#ctor(serviceProvider,logger,ignoredTableRepository,searchViewModel,statusBarViewModel)

### Summary

Constructor that provides resources created by Dependency Injection.



### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |
| logger | [Microsoft.Extensions.Logging.ILogger{AAP.Applications.NetforumDataPurge.ConsoleApp.Mvvm.ViewModels.DashboardViewModel}](#T-Microsoft-Extensions-Logging-ILogger-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-DashboardViewModel-) |  |
| ignoredTableRepository | [AAP.Applications.NetforumDataPurge.ConsoleApp.NetForum.Repositories.IgnoredTableRepository](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Repositories-IgnoredTableRepository) |  |
| searchViewModel | [AAP.Applications.NetforumDataPurge.ConsoleApp.Mvvm.ViewModels.SearchViewModel](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-SearchViewModel) |  |
| statusBarViewModel | [AAP.Applications.NetforumDataPurge.ConsoleApp.Mvvm.ViewModels.StatusBarViewModel](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-StatusBarViewModel) |  |

#### Initialize
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Initialize'></a>Initialize()

### Summary

Called by Window
after it is loaded.



### Parameters

This method has no parameters.

### Remarks

* Initializes the [SearchViewModel](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-SearchViewModel) if
necessary.
* Always reads the \`P05-Whitelist Table\`.

#### Match
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Match'></a>Match()

### Summary

Method to apply Regular Expression matching to the list of
NetForum tables.



### Returns

of matching Tables.

### Parameters

This method has no parameters.

### Remarks

Updates the \`Matches\` property.

#### ReadWhitelist
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-ReadWhitelist'></a>ReadWhitelist()

### Summary

Method used to populate the \`Whitelist\` property from the
\`P05-Whitelist Table\`.



### Parameters

This method has no parameters.

#### SaveRegex
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-SaveRegex'></a>SaveRegex()

### Summary

Saves the current Regular Expression to
the \`P05-Whitelist Table\`.



### Parameters

This method has no parameters.

#### Dispose
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-Dispose'></a>Dispose()

### Summary

implementation.



### Parameters

This method has no parameters.

#### DeleteRegex
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-DeleteRegex-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Entities-IgnoredTable-'></a>DeleteRegex(regex)

### Summary

Removes the selected [IgnoredTable](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Entities-IgnoredTable)
from the \`P05-Whitelist Table\`.



### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| regex | [AAP.Applications.NetforumDataPurge.ConsoleApp.NetForum.Entities.IgnoredTable](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-NetForum-Entities-IgnoredTable) |  |

#### Main
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Program-Main-System-String---'></a>Main(args)

### Summary

Application entry point.  Creates an instance of [Startup](#P-AAP-Applications-NetforumDataPurge-ConsoleApp-Program-Startup)
then requests a \`Host\` from it and runs it.



### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

#### BuildHost
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-BuildHost-System-String---'></a>BuildHost(args)

### Summary

Entry point to obtaining an instance of 
which controls the state of the application.



### Returns

Configured and built host.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

#### GetConnection
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-GetConnection-System-IServiceProvider-'></a>GetConnection(provider)

### Summary

Creates instances of NfDbConnection



### Returns

populated with appropriate
connection string based on number of threads being used.

### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| provider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |

#### Conn_InfoMessage
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-Startup-Conn_InfoMessage-System-Object,Avectra-netForum-Common-NfDbInfoMessageEventArgs-'></a>Conn_InfoMessage(sender,e)

### Summary

Handles \`NfDbConnection\`'s async information event.



### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [Avectra.netForum.Common.NfDbInfoMessageEventArgs](#T-Avectra-netForum-Common-NfDbInfoMessageEventArgs) |  |

### Remarks

Stores error messages on an instance of [ThreadHelper](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-Helpers-Debugging-ThreadHelper)
for consumption at a different point on the call stack in the same thread.

#### #ctor
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App--ctor-System-IServiceProvider-'></a>#ctor(services)

### Summary

Created by the [WpfHost](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-WpfHost).



### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') | [IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider')
instance for the [AppDomain](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.AppDomain 'System.AppDomain'). |

#### Cleanup
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App-Cleanup'></a>Cleanup()

### Summary

Called from [Launcher](#launcher) to stop the main window.



### Parameters

This method has no parameters.

#### Main
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-App-Main'></a>Main()

### Summary

Application Entry Point.



### Parameters

This method has no parameters.

#### SelectTemplate
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Converters-TableTemplateSelector-SelectTemplate-System-Object,System-Windows-DependencyObject-'></a>SelectTemplate(item,container)

### Summary





### Returns



### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| container | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') |  |

#### InitializeComponent
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Dashboard-InitializeComponent'></a>InitializeComponent()

### Summary

InitializeComponent



### Parameters

This method has no parameters.

#### InitializeComponent
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-MainWindow-InitializeComponent'></a>InitializeComponent()

### Summary

InitializeComponent



### Parameters

This method has no parameters.

#### InitializeComponent
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Schedule-InitializeComponent'></a>InitializeComponent()

### Summary

InitializeComponent



### Parameters

This method has no parameters.

#### #ctor
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist--ctor-System-IServiceProvider,AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel-'></a>#ctor(serviceProvider,viewModel)

### Summary

Public constructor for this Window.



### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| serviceProvider | [System.IServiceProvider](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IServiceProvider 'System.IServiceProvider') |  |
| viewModel | [AAP.Applications.NetforumDataPurge.ConsoleApp.Mvvm.ViewModels.WhitelistViewModel](#T-AAP-Applications-NetforumDataPurge-ConsoleApp-Mvvm-ViewModels-WhitelistViewModel) |  |

### Remarks

_Parameters constructed by Dependency Injection._

#### InitializeComponent
### Method: <a name='M-AAP-Applications-NetforumDataPurge-ConsoleApp-WPF-Forms-Whitelist-InitializeComponent'></a>InitializeComponent()

### Summary

InitializeComponent



### Parameters

This method has no parameters.
