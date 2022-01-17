import { Component, OnInit } from '@angular/core';
import { BlogpostService } from '../blogpost.service';
import { Blogpost } from '../Models/Blogpost';

@Component({
  selector: 'app-blogpost',
  templateUrl: './blogpost.component.html',
  styleUrls: ['./blogpost.component.css']
})
export class BlogpostComponent implements OnInit {

  blogposts: Blogpost[] = []

  constructor(private blogPostService: BlogpostService) { }

  ngOnInit(): void {
    this.getBlogposts();
  }

  getBlogposts(): void {
    this.blogPostService.getBlogPosts()
      .subscribe(blogposts => { this.blogposts = blogposts; console.log(blogposts); });
  }

}
