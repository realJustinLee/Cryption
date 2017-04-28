//
//  ViewController.m
//  Cryption
//
//  Created by 李欣 on 2017/4/22.
//  Copyright © 2017年 李欣. All rights reserved.
//

#import "ViewController.h"

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    [self.button1 setAction:@selector(button1Click:)];
    // Do any additional setup after loading the view.
    [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(sayHello:) name:@"NCSayHello" object:nil];
}


- (void)setRepresentedObject:(id)representedObject {
    [super setRepresentedObject:representedObject];

    // Update the view, if already loaded.
}

-(void)viewWillDisappear{
    [[NSNotificationCenter defaultCenter]
     removeObserver:self name:@"NCSayHello" object:nil];
}

-(void)button1Click:(id)sender{
    [[NSNotificationCenter defaultCenter]
     postNotificationName:@"NCSayHello" object:nil];
}

-(void) sayHello:(NSNotification*)notification{
    NSAlert *alert = [[NSAlert alloc]init];
    [alert addButtonWithTitle:@"确定"];
    [alert setMessageText:@"Hello"];
    [alert runModal];
}

@end
