   M S B A M L   `   `   `  ����F  BWebBrowsers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WebBrowsersWebBrowsers  5   	   T PCefSharp.Wpf, Version=53.0.0.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138A0clr-namespace:CefSharp.Wpf;assembly=CefSharp.WpfCefSharp.Wpf 5   	       WebBrowsers.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WebBrowsers     5   	   Clibcef0clr-namespace:CefSharp.Wpf;assembly=CefSharp.Wpf     5   	   Z VEO.WebBrowser.Wpf, Version=16.2.72.0, Culture=neutral, PublicKeyToken=e92353a6bf73fffc1eo(http://schemas.essentialobjects.com/wpf/  5   	   -   5          � Title$  WebBrowsers��5
   	   .��5      � -   5         �Name$
 grid��5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� #��� ��6   $��0q�6U   $��3��6`   �� 5   
   -   5         ��Name$ utlsmenuStackPanel��5      $��0��61    �� Orientation$ 
Horizontal=�6A   $��3��6Z   $��Center=�6n   .+�5      �� -   5         ��Name$ textBox��5      $��23��6'   $��0q�63    �� TextWrapping$
 Wrap=�6>   $��http://www.yahoo.co.jp��6R   $��Center=�6p   $��Center=�6�   $	��450��6�   �� 5      -   5        $��Yahoo!��5      $��Center=�6&   $��8,3,0,0q�6C   $	��Top=�6T   $��75��6l   6w   �� 5      -   5        $��	確認君��5      $��Center=�6#   $��8,3,0,0q�6@   $	��Top=�6Q   $��75��6i   6t   �� 5      -   5        $��mztm.jp��5      $��Center=�6'   $��8,3,0,0q�6D   $	��Top=�6U   $��75��6m   6x   5      (  "System.Windows.Controls.WebBrowser  5    
   -   5          Name$ 
webBrowser��5       $��0,0,0,21q�6)   $��1��6;   6H   �� 5!   
   -	   5        	 ��Name$	 webBrowserTextBlock��5!      $��8,0,0,2q�61   $��1��6B   $
��Wrap=�6O   $�� ��6c   $��Bottom=�6k   �� 5#   
   $��1��6   $��1��6$   $
��Left=�64   $��Stretch=�6O   $��4��6k   %  CefSharp.Wpf.ChromiumWebBrowser  5$   
   -
   5        
  Name$
 chromiumWebBrowser��5$   $      Address$  ��6@   $��1��6K   $��1��6X   $��4,0,0,21q�6h   �� 5%   
   -   5        $!	 chromiumWebBrowserTextBlock��5%      $��8,0,0,2q�69   $��1��6J   $
��Wrap=�6W   $�� ��6k   $��Bottom=�6s   $��1��6�   �� 5'   
   $��1��6   $��2��6$   $
��Left=�64   $��Stretch=�6O   $��4��6k   "  EO.WebBrowser.Wpf.WebControl  5(   
   -   5          Name$ eoWebControl��5(      $��4,0,0,21q�6.   $��1��6@   $��2��6M   �� 5)   
   -   5        $	 eoWebControlTextBlock��5)      $��8,0,0,2q�63   $��1��6D   $
��Wrap=�6Q   $�� ��6e   $��Bottom=�6m   $��2��6�   5*      5+      