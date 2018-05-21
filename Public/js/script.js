$(document).ready(function () {
    $(".category .owl-carousel").owlCarousel( {
        loop:true,
        nav:true,
        responsive:{
            0:{
                items:1
            },
            600:{
                items:4
            },
            1000:{
                items:9
            }
        }
    });
    $(".latest-blog .owl-carousel").owlCarousel( {
        center: true,
        loop:true,
        nav:true,
        items:3,
        margin:10,
        responsive:{
            0:{
                items:1
            },
            600:{
                items:2
            },
            1000:{
                items:3
            }
        }
    });
    $(".trending .owl-carousel").owlCarousel( {
        center: true,
        loop:true,
        nav:true,
        items:4,
        margin:10,
        responsive:{
            0:{
                items:1
            },
            600:{
                items:2
            },
            1000:{
                items:4
            }
        }
    });
  
//     if($(document).width()<900)
//     {
//      $(".menu-navbar").toggleClass("navbar-display-none")
//      $(".navbar").toggleClass("navbar-display-block")
//      $( ".owl-prev").toggleClass("navbar-display-none")
//      $( ".owl-next").toggleClass("navbar-display-none")
//  }
$('.our-partners .owl-carousel').owlCarousel({
    center: true,
    // autoplay:true,
    autoplayTimeout:4000,
    items:5,
    loop:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:4
        }
    }
});
$('.slider .owl-carousel').owlCarousel({
    center: true,
    // autoplay:true,
    autoplayTimeout:4000,
    items:2,
    loop:true,
    dots:false,
    margin:10,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:2
        },
        1000:{
            items:2
        }
    }

    
});

 

    

    $( ".owl-prev").html('<i class="fa fa-arrow-left"></i>');
    $( ".owl-next").html('<i class="fa fa-arrow-right"></i>');



$('.slider-deals .owl-carousel').owlCarousel({
    center: true,
    // autoplay:true,
    autoplayTimeout:4000,
    items:1,
    loop:true,
    dots:false,
    margin:10,
});

 

    

    $( ".owl-prev").html('<i class="fa fa-arrow-left"></i>');
    $( ".owl-next").html('<i class="fa fa-arrow-right"></i>');




$('.slider-blog .owl-carousel').owlCarousel({
    center: true,
    // autoplay:true,
    autoplayTimeout:4000,
    items:1,
    loop:true,
    dots:false,
    margin:10,
});

 

var a = 1;


    $(".product-count .minus").click(function () {

        if ($(".product-count input").val() > 0) {
            a = a - 1;
            $(this).closest(".product-count ").find("input").val(a);
        }
    })

    $(".product-count .plus").click(function () {
        //console.log($(".product-count .plus"))
        //console.log($(".product-count input").val())
        
        a = a + 1;
        //$(this).siblings('input')
        $(this).closest(".product-count ").find("input").val(a);
        //$(".product-count input").val(a);
    })



    $(".owl-prev").html('<i class="fa fa-arrow-left"></i>');
    $(".owl-next").html('<i class="fa fa-arrow-right"></i>');



});