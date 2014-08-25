﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScrabbleBrowser.aspx.cs"
    Inherits="TopMachine.Web.GameViewer.ScrabbleBrowser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <link href="Styles/Site.css" rel="stylesheet" type="text/css" />
    <link href="Styles/Grid.css" rel="stylesheet" type="text/css" />
    <link href="Styles/custom/jquery-ui-1.8.12.custom.css" rel="stylesheet" type="text/css" />
    <link href="Styles/showLoading.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery/jquery-1.5.1.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery/jquery.xml2json.pack.js" type="text/javascript"></script>
    <script src="Scripts/jquery/jquery-ui-1.8.12.custom.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery/jquery.layout-latest.js" type="text/javascript"></script>
    <script src="Scripts/jquery/jquery.showLoading.min.js" type="text/javascript"></script>
    <script src="Scripts/Local/GameLoaderProxy.js" type="text/javascript"></script>
    <script src="Scripts/Local/GameParameters.js" type="text/javascript"></script>
    <script src="Scripts/GameController.js" type="text/javascript"></script>
    <script src="Scripts/GameLoader.js" type="text/javascript"></script>
    <script src="Scripts/Grid.js" type="text/javascript"></script>
    <script src="Scripts/Rack.js" type="text/javascript"></script>
    <script src="Scripts/History.js" type="text/javascript"></script>
    <script src="Scripts/Comments.js" type="text/javascript"></script>
    <script src="Scripts/Rankings.js" type="text/javascript"></script>
    <script src="Scripts/TopInfo.js" type="text/javascript"></script>
    <script src="Scripts/GameState.js" type="text/javascript"></script>
    <script src="Scripts/RoundControl.js" type="text/javascript"></script>
    <script src="Scripts/Application.js" type="text/javascript"></script>
    <script src="Scripts/Chrono.js" type="text/javascript"></script>
    <script src="Scripts/Messsage.js" type="text/javascript"></script>
</head>
<body>
<form runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    <Services>
    <asp:ServiceReference Path="~/Services/Topping.svc" />
    </Services>
    </asp:ScriptManager>
</form>
    <div class="ui-layout-north ui-widget-header">
        <div style="float: right" class="menu">
            <ul>
                <li><a id="viewGame" href="#">Visualisez une partie</a></li>
                <li><a id="viewPlayGame" href="#">Jouez une partie</a></li>
            </ul>
        </div>
        <img width="80px" height="80px" src="images/tmlogo.png" />
    </div>

        <div id="playGround" class="ui-layout-center ui-widget-header">
            <div id="grid" class="ui-layout-center">
            </div>
            <div id="rack" class="ui-layout-south">
                <center>
                    <table style="display: inline-block">
                        <tr>
                        </tr>
                    </table>
                </center>
            </div>
        </div>

    <div class="ui-layout-east ui-widget-header">
        <div id="nav">
            <div style="padding: 0px">
                <div class="menu" id="rackControl">
                    <ul>
                        <li><a href="#" id="getSolution">Solution</a></li>
                        <li><a href="#" id="previousRound">&lt;</a></li>
                        <li><span id="lblRound">Coup</span></li>
                        <li><a href="#" id="nextRound">&gt;</a></li>
                        <li><span id="lblChrono">00:00</span></li>
                        <li><span id="lblScore">Score</span></li>
                        <li><span id="lblPourcentage" style="display: none">100%</span></li>
                    </ul>
                </div>
                <div class="menu" id="posTop">
                    <ul id="posTopRow">
                        <li><span>Top</span> </li>
                        <li class="word"><span>-</span> </li>
                        <li><span>-</span> </li>
                        <li><span>-</span> </li>
                    </ul>
                    <br />
                    <ul id="posJoueurRow" style="width: 100%">
                        <li><span>Joueur</span> </li>
                        <li class="word"><span>-</span> </li>
                        <li><span>-</span> </li>
                        <li><span>-</span> </li>
                    </ul>
                </div>
            </div>
        </div>
        <div id="tabs" class="ui-layout-center">
            <ul>
                <li><a href="#tabComments">Commentaires</a></li>
                <li><a href="#tabHistory">Historique</a></li>
                <li><a href="#tabRankings">Classement</a></li>
            </ul>
            <div id="tabComments">
                <p>
                    Au fil de la partie, s'afficheront des commentaires. Il existe différents types
                    de commentaires, avec des icônes différents. Pour tester : <a href="Start.htm?gameid=1#">
                        Start.htm?gameid=1#</a></p>
                <p>
                    Au premier coup, affichez la solution : Bouton '?'. De nouveaux commentaires apparaissent,
                    si vous cliquez sur le lien 'CAMES', la solution apparait. Pour voir comment cela
                    fonctionne. Voyez le fichier Games/1.xml</p>
            </div>
            <div id="tabHistory">
            </div>
            <div id="tabRankings">
                <ul>
                    <li><a href="#tabRankingDetail">Détail</a></li>
                    <li><a href="#tabRankingGame">Partie</a></li>
                    <li><a href="#tabRankingGlobal">Général</a></li>
                </ul>
                <div id="tabRankingDetail">
                    <div class="menu" id="Div1">
                        <ul>
                            <li class="refresh"><a href="#" id="btnRankingDetail">Rafraîchir</a></li>
                        </ul>
                    </div>
                    <table id="listRankingDetail" cellspacing='0' cellpadding='0' class='list'>
                        <tr>
                        </tr>
                    </table>
                </div>
                <div id="tabRankingGame">
                    <div class="menu" id="Div2">
                        <ul>
                            <li class="refresh"><a href="#" id="btnRankingGame">Rafraîchir</a></li>
                        </ul>
                    </div>
                    <table id="listRankingGame" cellspacing='0' cellpadding='0' class='list'>
                        <tr>
                        </tr>
                    </table>
                </div>
                <div id="tabRankingGlobal">
                    <div class="menu" id="Div3">
                        <ul>
                            <li class="refresh"><a href="#" id="btnRankingGlobal">Rafraîchir</a></li>
                        </ul>
                    </div>
                    <table id="listRankingGlobal" cellspacing='0' cellpadding='0' class='list'>
                        <tr>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>

<div id="dialog-modal" title="Basic modal dialog" style="display:none">
	<p>Adding the modal overlay screen makes the dialog look more prominent because it dims out the page content.</p>
</div>


</body>
</html>
