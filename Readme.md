### Flat ComboBox - Change border color and Dropdown button color

You need to handle `WM_PAINT` yourself and draw the border and the dropdown rectangle. This is the way that internal [`ComboBox.FlatComboAdapter`](http://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/ComboBox.cs,79ca61e52b2766da) class of .Net Framework works.
 
In this post, I've created a `FlatComboBox`, which draws the border and the dropdown in a flat style, having the following additional properties:

- BorderColor: used for border and for the dropdown arrow
- ButtonColor: used for dropdown area color.

![FlatComboBox.png](/images/FlatComboBox.png)
![FlatComboBox-Properties.png](/images/FlatComboBox-Properties.png)