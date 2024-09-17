const source = "http://localhost:5267/content/1c63e630-8865-462d-8453-a3b846c55a50";

window.onload = function()
{
    const video = document.getElementsByTagName('hls-video')[0];
    video.src = source;
};