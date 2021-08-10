mov ah,0x0e ;tty mode
mov al, 'H'
int 0x10
mov al,'e'
int 0x10
mov al,'l'
int 0x10
int 0x10
mov al,'o'
int 0x10
loop:
    jmp loop
times 510 -($-$$) db 0 ;set 510 00
dw  0xaa55 ;magic number ,,,,,0x7c00- boot sector stored address