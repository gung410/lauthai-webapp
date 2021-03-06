import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { AdminComponent } from './admin.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { SharedModule } from '../shared/shared.module';
import { ManagementComponent } from './management/management.component';
import { CreateProfileDialogComponent } from './management/create-profile-dialog/create-profile-dialog.component';
import { UpdateProfileDialogComponent } from './management/update-profile-dialog/update-profile-dialog.component';
import { DeleteProfileDialogComponent } from './management/delete-profile-dialog/delete-profile-dialog.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FeedbackComponent } from './feedback/feedback.component';

@NgModule({
  declarations: [
    AdminComponent,
    DashboardComponent,
    ManagementComponent,
    CreateProfileDialogComponent,
    UpdateProfileDialogComponent,
    DeleteProfileDialogComponent,
    NavbarComponent,
    FeedbackComponent
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    SharedModule
  ]
})
export class AdminModule { }
