// JavaScript Document
function MakeHead()
{
	"use strict";
	var bod = document.getElementById("Body");
	var head = document.createElement("header");
	
	var head1 = document.createElement("h1");
	head1.innerHTML = "CS 499 Senior Design Team 4";
	
	var head2 = document.createElement("h2");
	head2.innerHTML = "Project Name";
	
	var head3 = document.createElement("h4");
	head3.innerHTML = 'Justin Hill, Angelo Stekardis,     Matthew Hutchinson, Joe Weisbrod';
	
	var nav = document.createElement("nav");
	
	var nav1 = document.createElement("a");
	nav1.innerHTML = "Home";
	nav1.setAttribute("href", "index.html");
	
	var nav2 = document.createElement("a");
	nav2.innerHTML = "Code Repository";
	nav2.setAttribute("href", "https://github.com/justinwhill94/Senior-Design");
	
	var nav3 = document.createElement("a");
	nav3.innerHTML = "Engineering Journals";
	nav3.setAttribute("href", "http://measuredsolutions.weebly.com/");
	
	bod.appendChild(head);
	head.appendChild(head1);
	head.appendChild(head2);
	head.appendChild(head3);
	bod.appendChild(nav);
	nav.appendChild(nav1);
	nav.appendChild(nav2);
	nav.appendChild(nav3);
	
	
	return;
}