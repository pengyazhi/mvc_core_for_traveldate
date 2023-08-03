

$(".category-click").on('click', function () {
    const $arrowBottomDown = $(this).find("#arrow_bottom_down");
    const $arrowTopUp = $(this).find("#arrow_top_up");
    $(this).next(".filter-block-toggle").slideToggle(); //.drop_down_list_center 是下一個同級元素
    $arrowBottomDown.toggle();
    $arrowTopUp.toggle();
});




$('.uncheckbox').on('click',function(){
    $(this).hide();
    $(this).next(".checkbox").show();
    
});
$('.checkbox').on('click',function(){
    $(this).hide();
    $(this).prev(".uncheckbox").show();
});


