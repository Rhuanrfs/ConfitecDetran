import { isNull } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-incluir',
  templateUrl: './incluir.component.html',
  styleUrls: ['./incluir.component.css']
})
export class IncluirComponent implements OnInit {

  constructor(private route: ActivatedRoute) { }

  Id = 0;

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      if(!isNull(params["id"]))
        this.Id = params["id"];
  });
  }

}
