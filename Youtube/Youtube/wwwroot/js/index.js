function Add() {
    let head = document.createElement("h2");
    head.innerHTML = "Just Chill";
    let add = document.querySelectorAll("h1");
    add[1].after(head);



}