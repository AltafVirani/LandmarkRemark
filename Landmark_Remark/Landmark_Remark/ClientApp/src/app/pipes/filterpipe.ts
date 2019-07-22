import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filterPipe'
})
export class FilterPipe implements PipeTransform {

  transform(items: any[], searchToken: string) {
    console.log("search token" + searchToken);
    console.log("items");
    console.log(items);

    if (searchToken == null)
      searchToken = "";


    searchToken = searchToken.toLowerCase();

    return items.filter(elem => elem.userName.toLowerCase().indexOf(searchToken) > -1
      || elem.comment.toLowerCase().indexOf(searchToken) > -1
    );
  }

}
