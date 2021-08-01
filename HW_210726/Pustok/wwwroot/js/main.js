﻿$(document).ready(function () {
    $(document).on("click", ".show-book-modal", function (e) {
        e.preventDefault();

        var url = $(this).attr("href");

        async function ResponseHtml() {
            const response = await fetch(url)
                .then(resp => resp.text())
                .then(data =>

                    $("#quickModal .product-details-modal").html(data)
                    );
        }

        ResponseHtml();

        //#region elave
        //fetch(url)
        //    .then(respons => respons.text())
        //    .then(data => {

        //        //#region elave
        //        //console.log(data);
        //        //var htnlStr =`<div class="product-details-modal">
        //        //                    <div class="row">
        //        //                        <div class="col-lg-5">
        //        //                            <!-- Product Details Slider Big Image-->
        //        //                           <img class="poster" src="/image/products/`+ data.bookImages[0].image +`" alt="">
        //        //                        </div>
        //        //                        <div class="col-lg-7 mt--30 mt-lg--30">
        //        //                            <div class="product-details-info pl-lg--30 ">
        //        //                                <p class="tag-block">Tags: <a href="#">Movado</a>, <a href="#">Omega</a></p>
        //        //                                <h3 class="product-title">`+data.name+`</h3>
        //        //                                <ul class="list-unstyled">
        //        //                                    <li>Ex Tax: <span class="list-value"> £60.24</span></li>
        //        //                                    <li>Brands: <a href="#" class="list-value font-weight-bold"> Canon</a></li>
        //        //                                    <li>Product Code: <span class="list-value"> model1</span></li>
        //        //                                    <li>Reward Points: <span class="list-value"> 200</span></li>
        //        //                                    <li>Availability: <span class="list-value"> In Stock</span></li>
        //        //                                </ul>
        //        //                                <div class="price-block">
        //        //                                    <span class="price-new">£73.79</span>
        //        //                                    <del class="price-old">£91.86</del>
        //        //                                </div>
        //        //                                <div class="rating-widget">
        //        //                                    <div class="rating-block">
        //        //                                        <span class="fas fa-star star_on"></span>
        //        //                                        <span class="fas fa-star star_on"></span>
        //        //                                        <span class="fas fa-star star_on"></span>
        //        //                                        <span class="fas fa-star star_on"></span>
        //        //                                        <span class="fas fa-star "></span>
        //        //                                    </div>
        //        //                                    <div class="review-widget">
        //        //                                        <a href="#">(1 Reviews)</a> <span>|</span>
        //        //                                        <a href="#">Write a review</a>
        //        //                                    </div>
        //        //                                </div>
        //        //                                <article class="product-details-article">
        //        //                                    <h4 class="sr-only">Product Summery</h4>
        //        //                                    <p>
        //        //                                        Long printed dress with thin adjustable straps. V-neckline and wiring under
        //        //                                        the Dust with ruffles
        //        //                                        at the bottom
        //        //                                        of the
        //        //                                        dress.
        //        //                                    </p>
        //        //                                </article>
        //        //                                <div class="add-to-cart-row">
        //        //                                    <div class="count-input-block">
        //        //                                        <span class="widget-label">Qty</span>
        //        //                                        <input type="number" class="form-control text-center" value="1">
        //        //                                    </div>
        //        //                                    <div class="add-cart-btn">
        //        //                                        <a href="#" class="btn btn-outlined--primary">
        //        //                                            <span class="plus-icon">+</span>Add to Cart
        //        //                                        </a>
        //        //                                    </div>
        //        //                                </div>
        //        //                                <div class="compare-wishlist-row">
        //        //                                    <a href="#" class="add-link"><i class="fas fa-heart"></i>Add to Wish List</a>
        //        //                                    <a href="#" class="add-link"><i class="fas fa-random"></i>Add to Compare</a>
        //        //                                </div>
        //        //                            </div>
        //        //                        </div>
        //        //                    </div>
        //        //                </div>
        //        //                <div class="modal-footer">
        //        //                    <div class="widget-social-share">
        //        //                        <span class="widget-label">Share:</span>
        //        //                        <div class="modal-social-share">
        //        //                            <a href="#" class="single-icon"><i class="fab fa-facebook-f"></i></a>
        //        //                            <a href="#" class="single-icon"><i class="fab fa-twitter"></i></a>
        //        //                            <a href="#" class="single-icon"><i class="fab fa-youtube"></i></a>
        //        //                            <a href="#" class="single-icon"><i class="fab fa-google-plus-g"></i></a>
        //        //                        </div>
        //        //                    </div>
        //        //                </div>`
        //        //#endregion

        //        $("#quickModal .product-details-modal").html(data);
        //    });

        //#endregion

        $("#quickModal").modal("show");
        

    });

    $(document).on("click", ".add-basket", function (e) {
        e.preventDefault();
        
        var url = $(this).attr("href");

        console.log(url);

        async function ResponseHtml() {
            const response = await fetch(url)
                .then(resp => resp.text())
                .then(data =>

                    $(".cart-widget .cart-block").html(data)
                );
        }

        ResponseHtml();


    });

    $(document).on("click", ".cross-btn", function (e) {
        e.preventDefault();

        var url = $(this).attr("href");

        console.log(url);

        async function ResponseHtml() {
            const response = await fetch(url)
                .then(resp => resp.text())
                .then(data =>

                    $(".cart-widget .cart-block").html(data)
                );
        }

        ResponseHtml();
    });

    $(document).on("click", "[data-target='grid']", function (e) {
        $(".first-toolbar .sorting-btn").each(function (e) {
            if ($(this).attr("data-target") == "grid") {
                console.log("no list");
                console.log($(this));
                $(".product-grid-content").css("display", "block");
            } 
        });
    });

    $(document).on("click", "[data-target='grid-four']", function (e) {

        $(".first-toolbar .sorting-btn").each(function (e) {
            
            if ($(this).attr("data-target") == "grid-four") {
                $(".product-grid-content").css({
                    "height": "500px",
                    "display": "flex",
                    "flex-direction": "column",
                    "justify-content": "space-between"
                });
            }

        });
    });

    $(document).on("click", "[data-target='list']", function (e) {

        $(".first-toolbar .sorting-btn").each(function (e) {
            if ($(this).attr("data-target") != "list") {
                $(".product-grid-content").css("display","none");
            }
        });
    });

})