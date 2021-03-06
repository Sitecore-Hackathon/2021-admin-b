<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sample Sublayout.ascx.cs" Inherits="Project.Common.layouts.Sample_Sublayout" %>

<html>
<head>
    <title>Movie Recommendations</title>

    <link href="https://netdna.bootstrapcdn.com/font-awesome/3.2.1/css/font-awesome.css" rel="stylesheet">
    <link href="~/css/moviestyles.css" />


    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

    <script src="~/js/moviescripts.js"></script>
</head>
<body>
    <div class="main">
        <div class="header-section">
            <h2><asp:Literal runat="server" ID="litIntro"></asp:Literal></h2>

            <div class="recommendation">
                <span class="no-rec">
                    Select some movies to get a recommendation
                </span>

                <div class="result">

                    <div class="selection-info">
                        <asp:Literal runat="server" ID="litRecommendedText"></asp:Literal>
                    </div>

                    <div class="movie-picture">

                    </div>
                    <div class="movie-info">
                        <span class="movie-title"></span>

                        <span class="movie-desc">

                        </span>
                    </div>
                </div>
            </div>
        </div>

        <div class="movie-grid">

            <asp:Repeater runat="server" ID="rptMoviesRepeater" OnItemDataBound="rptMoviesRepeater_bind">
                <ItemTemplate>
                    <div runat="server" id="divContainer" class="movie-tab">
                        <span class="title">
                            <asp:Literal runat="server" ID="litMovieTitle"></asp:Literal>
                        </span>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>

    </div>

    <div class="selection-bar">

        <a href="javascript:void(0)" class="close-bar"></a>

        <div class="movie-details">
            <div class="movie-picture">

            </div>

            <span class="movie-title"></span>

            <span class="movie-actors"></span>
        </div>
    </div>
</body>
</html>