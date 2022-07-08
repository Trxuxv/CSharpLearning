import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  menu = [
    {
      "id": 1,
      "name": "List",
      "routerlink": "/fetch-data/getList"
    },
    {
      "id": 2,
      "name": "Generics",
      "routerlink": "/fetch-data/2"
    },
    {
      "id": 3,
      "name": "Enumerable",
      "routerlink": "/fetch-data/GetEnumerable"
    }
  ]

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
