   M S B A M L   `   `   `  ����  XamlControls.TextEditing)    #XamlControls.TextEditing.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	    � WindowState$ 	Maximized=�6   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5	      $
��Auto �6   6,    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   6.   �� 5      $
��Auto �6   6.   .+�5   
   �� -   5        $��cbFontFamily��5      6)   �� 5   
   -   5        $��
cbFontSize��5      $��1��6%   .@�5      �� .��6   106   �� 5      .��6   116   �� 5      .��6   126   �� 5      .��6   136   �� 5      .��6   146   5      �� 5   
   -   5        $��txtMain��5      $��1��6!   $��2��6.    �� TextWrapping$
 Wrap=�6B   $	��500��6V   $	��300��6b    �� AcceptsReturn . 6�   �� 5   
   -   5        $��btnSave��5      $��2��6    .��6-   Save63   �� 5   
   -   5        $��btnLoad��5      $��2��6    $��1��6-   .��6=   Load6C   5      5      