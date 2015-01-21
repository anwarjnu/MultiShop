$(document).ready(function() {
$('#productMainImage a').click(function() {
var link = $(this);
if(!$('div.darkbox-frame').length) {
darkbox = $('<div class="darkbox-frame"><div class="darkbox-shadow"></div><div class="darkbox-canvas"><div class="darkbox-button"></div></div></div>').appendTo('body');
}
var frame = darkbox.clone().appendTo('body').addClass('darkbox-frame-on');
var shadow = frame.find('div.darkbox-shadow').animate({opacity:0.8},300);
var canvas = frame.find('div.darkbox-canvas');
var button = frame.find('div.darkbox-button');
var image = $('<img src="'+ link.attr('href') +'" alt="'+ link.attr('title') +'"/>');
image.appendTo(canvas);
image.load(function(){
var imageWidth = image.width();
var imageHeight = image.height();
var frameWidth = frame.width()-40;
var frameHeight = frame.height()-40;
if(imageWidth > frameWidth) {
imageWidth = frameWidth;
image.width(imageWidth);
while(image.height() > frameHeight) {
image.width(imageWidth);
imageWidth--;
}
imageHeight = image.height();
}
if(imageHeight > frameHeight) {
imageHeight = frameHeight;
image.height(imageHeight);
while(image.width() > frameWidth) {
image.height(imageHeight);
imageHeight--;
}
imageWidth = image.width();
}
canvas.addClass('darkbox-canvas-load').animate({
width:imageWidth,
marginLeft:-imageWidth/2,
height:imageHeight,
marginTop:-imageHeight/2
},500,function() {
canvas.addClass('darkbox-canvas-done');
button.addClass('darkbox-button-on');
button.addClass(navigator.platform.toLowerCase().indexOf('mac')+1?'darkbox-button-left':'darkbox-button-right');
image.animate({opacity:1},500,function() {
shadow.click(closer);
button.click(closer);
});
});
});
var closer = function() {
canvas.remove();
shadow.animate({opacity:0},300,function() {
frame.remove();
});
}
$(document).keydown(function(e) {
if(e.which==27) closer();
});
return false;
});
});