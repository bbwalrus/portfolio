// Enhanced scrolling functionality for skills section
function initializeScrollableSkills() {
    const skillsGrids = document.querySelectorAll('.skills-grid');
    
    skillsGrids.forEach(grid => {
        let isDown = false;
        let startX;
        let scrollLeft;
        
        // Mouse drag scrolling
        grid.addEventListener('mousedown', (e) => {
            isDown = true;
            grid.style.cursor = 'grabbing';
            startX = e.pageX - grid.offsetLeft;
            scrollLeft = grid.scrollLeft;
        });
        
        grid.addEventListener('mouseleave', () => {
            isDown = false;
            grid.style.cursor = 'grab';
        });
        
        grid.addEventListener('mouseup', () => {
            isDown = false;
            grid.style.cursor = 'grab';
        });
        
        grid.addEventListener('mousemove', (e) => {
            if (!isDown) return;
            e.preventDefault();
            const x = e.pageX - grid.offsetLeft;
            const walk = (x - startX) * 2; // Adjust scroll speed here
            grid.scrollLeft = scrollLeft - walk;
        });
        
        // Mouse wheel horizontal scrolling
        grid.addEventListener('wheel', (e) => {
            if (e.deltaY !== 0) {
                e.preventDefault();
                grid.scrollLeft += e.deltaY;
            }
        });
        
        // Touch scrolling for mobile devices
        let touchStartX = 0;
        let touchScrollLeft = 0;
        
        grid.addEventListener('touchstart', (e) => {
            touchStartX = e.touches[0].clientX;
            touchScrollLeft = grid.scrollLeft;
        });
        
        grid.addEventListener('touchmove', (e) => {
            const touchX = e.touches[0].clientX;
            const walk = (touchStartX - touchX) * 2;
            grid.scrollLeft = touchScrollLeft + walk;
        });
        
        // Keyboard navigation
        grid.addEventListener('keydown', (e) => {
            if (e.key === 'ArrowLeft') {
                e.preventDefault();
                grid.scrollLeft -= 150;
            } else if (e.key === 'ArrowRight') {
                e.preventDefault();
                grid.scrollLeft += 150;
            }
        });
        
        // Make grid focusable for keyboard navigation
        grid.setAttribute('tabindex', '0');
    });
}

// Initialize when DOM is loaded
document.addEventListener('DOMContentLoaded', initializeScrollableSkills);