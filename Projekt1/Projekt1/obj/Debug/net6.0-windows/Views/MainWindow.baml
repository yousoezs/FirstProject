   M S B A M L   `   `   `  ????C  ?Projekt1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Projekt1.ViewsProjekt1.Views  5      9!clr-namespace:Projekt1.ViewModelsProjekt1.ViewModels  5      /clr-namespace:Projekt1.ViewsProjekt1.Views  5	          Projekt1.Views.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Projekt1.Views     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      8
viewmodels!clr-namespace:Projekt1.ViewModels     5      .viewsclr-namespace:Projekt1.Views     5	        ? Title$  
MainWindow??5
      $	??800??5      $	??450??5      .??5      ?  ? 	Resources 5   
    ?? DataType&    Projekt1.ViewModels.UnoViewModel   Projekt1.Views.UnoView(   "Projekt1.ViewModels.PokerViewModel   Projekt1.Views.PokerView'   !Projekt1.ViewModels.GameViewModel   Projekt1.Views.GameView??%?   (??       5      *, +)(?? 2     5      *, +)(?? d     5      *, +)?? 5      "  6   .R?5        5      ?? 5      "  6   .R?5        5      ?? 5      "  6   .R?5        5      5      .+?5   
   ?? $	??130??5      $??52??5      $??	25,29,0,0q?5      $
??Left=?5      $	??Top=?5      $	??Uno??5!      ??5       ?? *NavigateUnoCommand+5!      ?? 5"   
   $	??138??5#      $??52??5$      $??
262,29,0,0q?5%      $
??Left=?5&      $	??Top=?5'      $??Poker??5)      ??5(      ?? *NavigatePokerCommand+5)      ?? 5*   
   $	??150??5+      $??52??5,      $??
559,29,0,0q?5-      $
??Left=?5.      $	??Top=?5/      $
??Game??51      ??50      ?? *NavigateGameCommand+51      ?? 53   
   ??6   ?? *CurrentViewModel+55      56      