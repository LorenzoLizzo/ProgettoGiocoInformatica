   M S B A M L   `   `   `  ����S  OProgettoGiocoInformatica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ProgettoGiocoInformaticaProgettoGiocoInformatica  5   	   ,    &ProgettoGiocoInformatica.Combattimento   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ProgettoGiocoInformatica     5   	     � Title$  Champions of the brawl��5   	   $	��350��6(   $	��525��65    � WindowStartupLocation$ CenterScreen=�6A    � 
ResizeMode$ NoResize=�6f   .��5	      �� -   5         ��Name$ canvasCombattimento��5	      |�. .+�5
   
   �� -   5         ��Name$ stackPanelP1��5
       �� Left$ 22��6+    �� Orientation$ Vertical=�6<   
 �� Top$	 170��6S   $��71��6d   .+�5      �� -   5         ��Name$ lblP1��5      $��P1��6#   $
��24,0q�60   �� 5      -   5        	 ��Name$	 imgPersonaggio1��5      $��68��6-   5      �� 5   
   -   5        $ stackPanelP2��5      $	 393��6+   $ Vertical=�6=   $	 170��6T   $��71��6e   .+�5      �� -   5        $ lblP2��5      $��P2��6#   $
��24,0q�60   �� 5      -   5        $	 imgPersonaggio2��5      $��68��6-   5      �� 5   
   -   5        $	 imgPavimento��5      $��62��6&   $	��519��62   $	 260��6>   $ 0��6O   $)��#.\Immagini\Pavimenti\pavimento1.png��6_   $
��Fill=�6�   � 5   
   -	   5        
 �Name$
 progressBarP1��5      $��29��6-   $ 10��69   $ 10��6J   $	��200��6Z   
���  �� � Maximum$	 120Q�6w   � 5   
   -
   5        $
 progressBarP2��5      $��29��6-   $	 299��69   $ 10��6K   $	��200��6[    J� RenderTransformOrigin$ 0.5,0.5&�6g   ���	#FFF00909$	 120Q�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$	 180Q�6&   T� 5      5      5      �� 5!   
   -   5         ��Name$ BtnGiocaAncora��5!      $��Gioca ancora��6)   $	��122��6@   $��60��6L   $��16(�6X   $y�Hidden=�6�   $ 88��6�   $	 151��6�   �� 5"   
   -   5        $ BtnHome��5"      $
��Home��6"   $	��122��61   $��60��6=   $��16(�6I   $y�Hidden=�6m   $	 290��6�   $	 151��6�   �� 5#   
   -   5        $ lblVincitore��5#      $�� ��6&   $ 52��61   $	 105��6B   $	��404��6S   $��20(�6_   $y�Hidden=�6m   $��Center=�6�   5$      5%      