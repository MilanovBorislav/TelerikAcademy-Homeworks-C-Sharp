   M S B A M L   `   `   `  ����V  RCommandBinding.ImageGallery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:CommandBinding.ImageGallery.UserControls(CommandBinding.ImageGallery.UserControls  5   	   ]3clr-namespace:CommandBinding.ImageGallery.ViewModel%CommandBinding.ImageGallery.ViewModel  5   	   ,    &CommandBinding.ImageGallery.MainWindow   5   	   GUserControls6clr-namespace:CommandBinding.ImageGallery.UserControls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   I	viewModel3clr-namespace:CommandBinding.ImageGallery.ViewModel     5   	   -   5        $��PnlMainWindow��5   4     � Title$  
MainWindow��6	    � WindowState$ 	Maximized=�6    � DataContext 5      :  4CommandBinding.ImageGallery.ViewModel.AlbumViewModel  5   
    � 	Resources 5	         tabHeaderTemplate �� Path �� 
TargetType �� Property �� Value  tabContentTemplate �� DataType4   .CommandBinding.ImageGallery.UserControls.Album��%�  &	        &	 <    �� 5
   
   .R�5      � $
��Auto��6   $
��Auto��6    .+�5      �� $��Header��6#   $��3q�6:   $��Center=�5      $��Center=�66   ��5      �� $ Id� 5      ���� 5      '��       " ��6    .�5      ��  � ��
 � � �6;   5      5      5      5      5      �� 5   
   "  62   .R�5      ��  6   �� *ImageModels+.+�5        5      5(      5*      .��5+      �� .+�5,   
   �� $	 �� IsSynchronizedWithCurrentItem$
	 TrueY�69   #��[  5-      
 �� ContentTemplate#
 [ 5.      ��5,      �� *AlbumModels+ �� SelectedItem 5/      �� *SelectedAlbum+�� 50   
    �� Orientation$ 
Horizontal=�6   .+�51      �� ��6   �� *	PrevImage+.��63   
Previous6=   �� 52      ��6   �� *	NextImage+.��63   Next69   53      �� 54   
   $ 
Horizontal=�6   $��Center=�6O    6.   �� *
NewImage+.+�55      �� Image Title6%   �� 56      $	��200��6-   ��6   �� *Title+6;   �� 57      Image Source6&   �� 58      $	��200��63   ��6   �� *ImageSource+6A   �� 59      $	��200��6y    6   ��  �� ElementName$ PnlMainWindow��$ DataContext���6Y   �� *AddNewImage+.��6�   Add New Image6�   5:      5<      5=      