$(document).ready(function () {
    $(".movie-tab").on("click", function () {

        if ($(this).hasClass("selected")) {
            $(this).removeClass("selected");

            if ($(".movie-tab.selected").length == 0 && $(".selection-bar").is(":visible")) {
                $(".selection-bar").animate({ width: 'toggle' }, 400);
            }
        } else {
            $(this).addClass("selected");

            showMovieDetails($(this));

            if (!($(".selection-bar").is(":visible"))) {
                $(".selection-bar").animate({ width: 'toggle' }, 400);
            }

            if ($(".movie-tab.selected").length >= 3) {
                getRecommendation();
            }
        }
    });

    $(".close-bar").on("click", function () {
        $(".selection-bar").animate({ width: 'toggle' }, 400);
    });

    function getRecommendation() {
        // call api with selected movie titles

        if (($(".selection-bar").is(":visible"))) {
            $(".selection-bar").animate({ width: 'toggle' }, 400);
        }

        var backgroundImg = "url(https://i.guim.co.uk/img/media/e16909014ff126f1eb2060ed99cf9a0c0f6ab45a/454_457_2331_1399/master/2331.jpg?width=1200&quality=85&auto=format&fit=max&s=40fffe2a8e68caa446f8a33cb4039333)"
        var year = "1998";
        var title = "Aliens (" + year + ")";
        var genre = "horror";
        var desc = "Lorem ipsum...."

        $(".result .selection-info").html(info);
        $(".result .movie-picture").css("background-image", backgroundImg);
        $(".result .movie-title").html(title);
        $(".result .movie-desc").html(desc);

        $(".no-rec").hide();
        $(".result").show();
    }

    function showMovieDetails(el) {
        var backgroundImg = $(el).css("background-image");
        $(".selection-bar .movie-picture").css("background-image", backgroundImg);
        $(".selection-bar .movie-title").html($(el).attr("data-title"));
        $(".selection-bar .movie-actors").html($(el).attr("data-actors"));
    }
})