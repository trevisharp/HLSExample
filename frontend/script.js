const source = "https://stream.mux.com/r4rOE02cc95tbe3I00302nlrHfT023Q3IedFJW029w018KxZA.m3u8";

window.onload = function()
{
    const video = document.getElementsByTagName('hls-video')[0];
    video.src = source;
};