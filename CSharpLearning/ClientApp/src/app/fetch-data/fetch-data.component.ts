import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent implements OnInit {
  public properties: ListCSharp[] = [];
  public namePage: string = "";
  public method;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private route: ActivatedRoute, private router: Router) {
    this.method = this.route.snapshot.paramMap.get('id');
  }

  ngOnInit() {
    this.router.routeReuseStrategy.shouldReuseRoute = () => {
      return false;
    }

    this.http.get<ListCSharp[]>(this.baseUrl + 'weatherforecast/' + this.method).subscribe(result => {
      this.properties = result;
      result.map(x => this.namePage = x.group)
    }, error => console.error(error));

  }

}

interface ListCSharp {
  propertyId: number;
  name: string;
  group: string;
  description: string;
}
