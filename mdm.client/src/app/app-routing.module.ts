import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { SongsComponent } from './songs/songs.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { SongsDetailComponent } from './songs-detail/songs-detail.component';

const routes: Routes = []

// const routes: Routes = [
//   { path: '', redirectTo: '/home', pathMatch: 'full' }, // Redirect root to Home
//   { path: 'home', component: AppComponent },
//   { path: 'songs', component: SongsComponent },
//   { path: 'detail', component: SongsDetailComponent },
//   { path: '**', component: PageNotFoundComponent } // Wildcard route for a 404 page
// ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
