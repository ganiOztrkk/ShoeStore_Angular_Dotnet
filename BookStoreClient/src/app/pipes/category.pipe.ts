import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'category'
})
export class CategoryPipe implements PipeTransform {

  transform(value: any[], search: string){
    if (search === "") return value;
    
    return value.filter(x => x.name.toLowerCase().includes(search.toLowerCase()));


  }

}
